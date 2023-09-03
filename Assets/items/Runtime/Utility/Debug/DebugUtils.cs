using UnityEngine.Assertions;

namespace Esuriru.Items.Utility.Debug
{
    public static class DebugUtils
    {
        // TODO - Add comments
        public static void Assert(bool condition, string message)
        {
            UnityEngine.Assertions.Assert.IsTrue(condition, message);
        }

        public static void Fatal(string message)
        {
            throw new AssertionException(message, message);
        }
    }
}