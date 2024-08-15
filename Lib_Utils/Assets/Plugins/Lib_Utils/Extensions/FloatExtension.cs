using System;

namespace Utils.Extensions
{
    public static class FloatExtension
    {
        public const float FLOAT_ZERO_THRESHOLD = 1e-6f;

        public static bool IsZero(this float number)
        {
            return MathF.Abs(number) < FLOAT_ZERO_THRESHOLD;
        }
    }
}