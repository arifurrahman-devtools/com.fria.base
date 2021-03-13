using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
namespace FRIA
{

    public class SpeedMath
    {
        [StructLayout(LayoutKind.Explicit)]
        public struct intfloatunion
        {
            [FieldOffset(0)]
            public float f;
            [FieldOffset(0)]
            public int i;
        }
        public static intfloatunion ifu = new intfloatunion();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Sqrt(float val)
        {
            ifu.i = 0;
            ifu.f = val;
            ifu.i = (1 << 29) + (ifu.i >> 1) - (1 << 22);

            return ifu.f;
        }
    }
}
