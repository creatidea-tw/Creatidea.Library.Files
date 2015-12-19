using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creatidea.Library.Files.Examples
{
    using MimeTypes;

    /// <summary>
    /// Class Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            Console.WriteLine("示範 MIME TYPE 相關：開始");
            TestMimeTypes();
            Console.WriteLine("示範 MIME TYPE 相關：結束");
        }

        /// <summary>
        /// 示範 MIME TYPE 相關
        /// </summary>
        private static void TestMimeTypes()
        {
            // Getting the mime type by an extension
            Console.WriteLine("txt -> " + MimeTypeMap.GetMimeType("txt"));
            Console.WriteLine(".jpg -> " + MimeTypeMap.GetMimeType(".jpg"));

            // Getting the extension by a mime type
            Console.WriteLine("audio/wav -> " + MimeTypeMap.GetExtension("audio/wav"));

            // Getting unknow mime type by an unknow extension
            Console.WriteLine(".aaa -> " + MimeTypeMap.GetMimeType(".aaa"));

            // Getting unknow extension by a unknow mime type
            try
            {
                Console.WriteLine("unknow/ext -> " + MimeTypeMap.GetExtension("unknow/ext"));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
        }
    }
}
