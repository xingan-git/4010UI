using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Variable
{
    public static char RxByte;
    public static string RxString = "";
    public static string RxInfo = "";
    public static int CmdStatus = 0; //0:normal 1:done -1:error -2:busy
    public static int CmdIndex = 0;
    public static int CmdTimeCount = 0;
    public static string StatusBuf = "";
    public static int UpdateRate = 5000;
}

