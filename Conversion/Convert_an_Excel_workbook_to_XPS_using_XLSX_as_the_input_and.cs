using System;
using Aspose.Cells;
using Aspose.Cells.Utility;

namespace AsposeCellsConversionDemo
{
    class Program
    {
        static void Main()
        {
            // Path to the source Excel file (XLSX)
            string sourcePath = "input.xlsx";

            // Desired path for the output XPS file
            string destPath = "output.xps";

            // Convert the XLSX workbook to XPS using Aspose.Cells ConversionUtility
            ConversionUtility.Convert(sourcePath, destPath);

            Console.WriteLine($"Conversion completed successfully: {sourcePath} -> {destPath}");
        }
    }
}