using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Variable
{

    public static string RxString = "";
    public static string RxInfo = "";
    public static int CmdStatus = 0; //0:idle 1:success -1:error
    public static int CmdIndex = 0;
    public static int CmdTimeCount = 0;
    public static string StatusBuf = "";
    public static int UpdateRate = 5000;
    public static string FileName = "";
    public static float CsvTimeCount = 0;
    public static int CommandMode = 0; //0:dilution 1:gas_ppb_eq0 2:gas_ppb_neq0 3:MS/TS/Stop/Purge
    public static bool O3Flag = false;
}

