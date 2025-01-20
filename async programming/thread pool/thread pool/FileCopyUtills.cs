using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thread_pool
{
    public delegate void FileProgressDelegate(string copyUnits, string totalUnits, int percentage);

    internal class FileCopyUtills
    {
        public event FileProgressDelegate EvtFileProgress;

        public void Copy(string src_fileName, string dst_fileName)
        {
            using (var src_file = new FileStream(src_fileName, FileMode.Open))
            using (var dst_file = new FileStream(dst_fileName, FileMode.Create))
            {
                int buff_size = 1024 * 1024;
                byte[] buff = new byte[buff_size];
                long totalSize = src_file.Length;
                int readed = 0;
                int read = 0;
                while ((read = src_file.Read(buff, 0, buff_size)) > 0)
                {
                    dst_file.Write(buff, 0, read);
                    readed += read;

                    if (EvtFileProgress != null)
                    {
                        string copyUnits = AutoUnitConvertUtills.Convert(readed);
                        string totalUnits = AutoUnitConvertUtills.Convert(totalSize);
                        int percentage = (int)(readed / totalSize * 100);
                        EvtFileProgress.Invoke(copyUnits, totalUnits, percentage);
                    }
                }
            }
        }

        //public static void Copy(string src_fileName, string dst_fileName, FileProgressDelegate? fileProgressDelegate)
        //{
        //    using (var src_file = new FileStream(src_fileName, FileMode.Open))
        //    using (var dst_file = new FileStream(dst_fileName, FileMode.Create))
        //    {
        //        int buff_size = 1024 * 1024;
        //        byte[] buff = new byte[buff_size];
        //        long totalSize = src_file.Length;
        //        int readed = 0;
        //        int read = 0;
        //        while((read = src_file.Read(buff, 0, buff_size)) > 0 )
        //        {
        //            dst_file.Write(buff, 0, read);
        //            readed += read;
        //
        //            if (fileProgressDelegate != null)
        //            {
        //                string copyUnits = AutoUnitConvertUtills.Convert(readed);
        //                string totalUnits = AutoUnitConvertUtills.Convert(totalSize);
        //                int percentage = (int)(readed / totalSize * 100);
        //                fileProgressDelegate.Invoke(copyUnits, totalUnits, percentage);
        //            }
        //        }
        //    }
        //}
    }
}
