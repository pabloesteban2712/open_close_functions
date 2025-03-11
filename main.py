import cv2
import numpy as np

# Cargamos la imagen en escala de grises
img = cv2.imread('photo.png', 0)

# Creamos un kernel (estructura para la operación)
kernel = np.ones((5,5), np.uint8)

# Aplicar operación de apertura
opening = cv2.morphologyEx(img, cv2.MORPH_OPEN, kernel)

# Mostramos la imagen original y el resultado de "open"
cv2.imshow('Original', img)
cv2.imshow('Open function', opening)
cv2.waitKey(0)
cv2.destroyAllWindows()

# Aplicamos la operación de cierre sobre la imagen (despues de Opening)
closing = cv2.morphologyEx(opening, cv2.MORPH_CLOSE, kernel)

# Mostramos las 3 imágenes
cv2.imshow('Original', img)
cv2.imshow('Opening', opening)
cv2.imshow('Close function', closing)
cv2.waitKey(0)
cv2.destroyAllWindows()