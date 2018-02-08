using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Crazy.Models.Dcb
{
    public class DcbMissModel
    {
        #region 属性

        public int No { get; set; }
        public int R1 { get; set; }
        public int R2 { get; set; }
        public int R3 { get; set; }
        public int R4 { get; set; }
        public int R5 { get; set; }
        public int R6 { get; set; }
        public int R7 { get; set; }
        public int R8 { get; set; }
        public int R9 { get; set; }
        public int R10 { get; set; }
        public int R11 { get; set; }
        public int R12 { get; set; }
        public int R13 { get; set; }
        public int R14 { get; set; }
        public int R15 { get; set; }
        public int R16 { get; set; }
        public int R17 { get; set; }
        public int R18 { get; set; }
        public int R19 { get; set; }
        public int R20 { get; set; }
        public int R21 { get; set; }
        public int R22 { get; set; }
        public int R23 { get; set; }
        public int R24 { get; set; }
        public int R25 { get; set; }
        public int R26 { get; set; }
        public int R27 { get; set; }
        public int R28 { get; set; }
        public int R29 { get; set; }
        public int R30 { get; set; }
        public int R31 { get; set; }
        public int R32 { get; set; }
        public int R33 { get; set; }

        public int B1 { get; set; }
        public int B2 { get; set; }
        public int B3 { get; set; }
        public int B4 { get; set; }
        public int B5 { get; set; }
        public int B6 { get; set; }
        public int B7 { get; set; }
        public int B8 { get; set; }
        public int B9 { get; set; }
        public int B10 { get; set; }
        public int B11 { get; set; }
        public int B12 { get; set; }
        public int B13 { get; set; }
        public int B14 { get; set; }
        public int B15 { get; set; }
        public int B16 { get; set; }

        #endregion

        #region 构造函数

        public DcbMissModel()
        {
            R1 = -1;
            R2 = -1;
            R3 = -1;
            R4 = -1;
            R5 = -1;
            R6 = -1;
            R7 = -1;
            R8 = -1;
            R9 = -1;
            R10 = -1;
            R11 = -1;
            R12 = -1;
            R13 = -1;
            R14 = -1;
            R15 = -1;
            R16 = -1;
            R17 = -1;
            R18 = -1;
            R19 = -1;
            R20 = -1;
            R21 = -1;
            R22 = -1;
            R23 = -1;
            R24 = -1;
            R25 = -1;
            R26 = -1;
            R27 = -1;
            R28 = -1;
            R29 = -1;
            R30 = -1;
            R31 = -1;
            R32 = -1;
            R33 = -1;

            B1 = -1;
            B2 = -1;
            B3 = -1;
            B4 = -1;
            B5 = -1;
            B6 = -1;
            B7 = -1;
            B8 = -1;
            B9 = -1;
            B10 = -1;
            B11 = -1;
            B12 = -1;
            B13 = -1;
            B14 = -1;
            B15 = -1;
            B16 = -1;
        }

        #endregion

        public void SetZero(DcbItemModel item)
        {
            SetZero("R", item.R1);
            SetZero("R", item.R2);
            SetZero("R", item.R3);
            SetZero("R", item.R4);
            SetZero("R", item.R5);
            SetZero("R", item.R6);
            SetZero("B", item.B);
        }

        private void SetZero(string colorStr, int value)
        {
            var type = typeof(DcbMissModel);
            {
                var property = type.GetProperty(colorStr + value);

                property.SetValue(this, 0);

                //object o = property.GetValue(miss, null);

                //var method = type.GetMethod("UpdateInpatientInfo");
                //method.Invoke(miss, new object[] { "12" });
            }
        }

        public void UpdateValue(DcbMissModel missOld)
        {
            #region old value + 1

            if (R1 < 0) R1 = missOld.R1 + 1;
            if (R2 < 0) R2 = missOld.R2 + 1;
            if (R3 < 0) R3 = missOld.R3 + 1;
            if (R4 < 0) R4 = missOld.R4 + 1;
            if (R5 < 0) R5 = missOld.R5 + 1;
            if (R6 < 0) R6 = missOld.R6 + 1;
            if (R7 < 0) R7 = missOld.R7 + 1;
            if (R8 < 0) R8 = missOld.R8 + 1;
            if (R9 < 0) R9 = missOld.R9 + 1;
            if (R10 < 0) R10 = missOld.R10 + 1;
            if (R11 < 0) R11 = missOld.R11 + 1;
            if (R12 < 0) R12 = missOld.R12 + 1;
            if (R13 < 0) R13 = missOld.R13 + 1;
            if (R14 < 0) R14 = missOld.R14 + 1;
            if (R15 < 0) R15 = missOld.R15 + 1;
            if (R16 < 0) R16 = missOld.R16 + 1;
            if (R17 < 0) R17 = missOld.R17 + 1;
            if (R18 < 0) R18 = missOld.R18 + 1;
            if (R19 < 0) R19 = missOld.R19 + 1;
            if (R20 < 0) R20 = missOld.R20 + 1;
            if (R21 < 0) R21 = missOld.R21 + 1;
            if (R22 < 0) R22 = missOld.R22 + 1;
            if (R23 < 0) R23 = missOld.R23 + 1;
            if (R24 < 0) R24 = missOld.R24 + 1;
            if (R25 < 0) R25 = missOld.R25 + 1;
            if (R26 < 0) R26 = missOld.R26 + 1;
            if (R27 < 0) R27 = missOld.R27 + 1;
            if (R28 < 0) R28 = missOld.R28 + 1;
            if (R29 < 0) R29 = missOld.R29 + 1;
            if (R30 < 0) R30 = missOld.R30 + 1;
            if (R31 < 0) R31 = missOld.R31 + 1;
            if (R32 < 0) R32 = missOld.R32 + 1;
            if (R33 < 0) R33 = missOld.R33 + 1;

            if (B1 < 0) B1 = missOld.B1 + 1;
            if (B2 < 0) B2 = missOld.B2 + 1;
            if (B3 < 0) B3 = missOld.B3 + 1;
            if (B4 < 0) B4 = missOld.B4 + 1;
            if (B5 < 0) B5 = missOld.B5 + 1;
            if (B6 < 0) B6 = missOld.B6 + 1;
            if (B7 < 0) B7 = missOld.B7 + 1;
            if (B8 < 0) B8 = missOld.B8 + 1;
            if (B9 < 0) B9 = missOld.B9 + 1;
            if (B10 < 0) B10 = missOld.B10 + 1;
            if (B11 < 0) B11 = missOld.B11 + 1;
            if (B12 < 0) B12 = missOld.B12 + 1;
            if (B13 < 0) B13 = missOld.B13 + 1;
            if (B14 < 0) B14 = missOld.B14 + 1;
            if (B15 < 0) B15 = missOld.B15 + 1;
            if (B16 < 0) B16 = missOld.B16 + 1;

            #endregion
        }
    }
}