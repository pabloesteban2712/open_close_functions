using System;
using Matrox.MatroxImagingLibrary;

class Program
{
    static void Main()
    {
        try
        {
            MIL_ID MilApplication, MilSystem, MilDigitizer, MilImage;

            MIL.MappAlloc(MIL.M_DEFAULT, ref MilApplication);

            MIL.MsysAlloc(MIL.M_DEFAULT, "M_SYSTEM_DEFAULT", MIL.M_DEFAULT, ref MilSystem);

            MIL.MdigAlloc(MilSystem, MIL.M_DEFAULT, "M_DEFAULT", MIL.M_DEFAULT, ref MilDigitizer);

            MIL.MbufAlloc2d(MilSystem, 640, 480, 8 + MIL.M_UNSIGNED, MIL.M_IMAGE + MIL.M_GRAB, ref MilImage);

            MIL.MdigGrab(MilDigitizer, MilImage);

            Console.WriteLine("Captura de imagen hecha.");
            MIL.MappFree(MilApplication);
        } 
        catch (Exception ex) // excepcion si salta un error
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}