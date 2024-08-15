using System.Numerics;

namespace Utils.Extensions
{
    public static class Vector2Extension
    {
        public static Vector2 Normalized(this Vector2 value)
        {
            var num = value.Length();
            return num > FloatExtension.FLOAT_ZERO_THRESHOLD ? value / num : Vector2.Zero;
        }
    }

    public static class Vector3Extension
    {
        public static Vector3 forward => Vector3.UnitZ;

        public static Vector3 Normalized(this Vector3 value)
        {
            var num = value.Length();
            return num > FloatExtension.FLOAT_ZERO_THRESHOLD ? value / num : Vector3.Zero;
        }
    }
}