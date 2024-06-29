using System;
using System.Collections.Generic;
using System.Text;

namespace SolidPrincipls
{
    public interface InterfaceSegregation
    {
        bool PrintContent(string content);
        bool FaxCopyContent(string content);

        bool ScanContent(string content);
        bool PhotoCopyContent(string content);


    }


}
