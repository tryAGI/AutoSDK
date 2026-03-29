//HintName: G.Models.TestSuitePhoneNumberProvider.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the provider of the phone number.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum TestSuitePhoneNumberProvider
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="test-suite")]
        TestSuite,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuitePhoneNumberProviderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuitePhoneNumberProvider value)
        {
            return value switch
            {
                TestSuitePhoneNumberProvider.TestSuite => "test-suite",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuitePhoneNumberProvider? ToEnum(string value)
        {
            return value switch
            {
                "test-suite" => TestSuitePhoneNumberProvider.TestSuite,
                _ => null,
            };
        }
    }
}