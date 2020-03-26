using EasyOffice.Enums;
using EasyOffice.Interfaces;
using EasyOffice.Models.Word;
using EasyOffice.Providers.NPOI;
using EasyOffice.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyOffice
{
    public class ServiceFactory
    {
        public static IWordExportService GetWordExportService(SolutionEnum solutionEnum= SolutionEnum.NPOI)
        {
            switch (solutionEnum)
            {
                case SolutionEnum.NPOI:
                    return new WordExportService(new WordExportProvider());
                default:
                    throw new NotImplementedException();
            }
        }
        public static IExcelImportService GetExcelImportService(SolutionEnum solutionEnum = SolutionEnum.NPOI)
        {
            switch (solutionEnum)
            {
                case SolutionEnum.NPOI:
                    return new ExcelImportService(new ExcelImportProvider());
                default:
                    throw new NotImplementedException();
            }
        }
        public static IExcelExportService GetExcelExportService(SolutionEnum solutionEnum = SolutionEnum.NPOI)
        {
            switch (solutionEnum)
            {
                case SolutionEnum.NPOI:
                    return new ExcelExportService(new ExcelExportProvider());
                default:
                    throw new NotImplementedException();
            }
        }
    }
   
}
