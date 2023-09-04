using UnityEngine.Assertions;

namespace Esuriru.Items.Utility.Debug
{
    public static class DebugUtils
    {
        /// <summary>
        /// Assert function
        /// </summary>
        /// <param name="condition">Condition that has to be true</param>
        /// <param name="message">Message when assertion fails</param>
        public static void Assert(bool condition, string message)
        {
            UnityEngine.Assertions.Assert.IsTrue(condition, message);
        }

        /// <summary>
        /// Fatal throw with message
        /// </summary>
        /// <param name="message">Exception message</param>
        /// <exception cref="AssertionException"></exception>
        public static void Fatal(string message)
        {
            throw new AssertionException(message, message);
        }
    }
}