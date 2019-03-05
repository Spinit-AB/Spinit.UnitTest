using Newtonsoft.Json;
using NUnit.Framework;

namespace Spinit.UnitTest.AssertExtensions
{
    public static class JsonAssert
    {
        /// <summary>
        /// Verifies that two objects are equal based on serialized json. Two objects are considered equal if both
        /// are null, or if both have the same value. NUnit has special semantics for some
        /// object types. If they are not equal an NUnit.Framework.AssertionException is
        /// </summary>
        /// <param name="expected">The value that is expected</param>
        /// <param name="actual">The actual value</param>
        public static void AreEqual(object expected, object actual) => Assert.AreEqual(JsonConvert.SerializeObject(expected), JsonConvert.SerializeObject(actual));
    }
}
