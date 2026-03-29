//HintName: G.Models.TestSuiteTestVoiceType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the test, which must be voice.
    /// </summary>
    public enum TestSuiteTestVoiceType
    {
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestSuiteTestVoiceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestSuiteTestVoiceType value)
        {
            return value switch
            {
                TestSuiteTestVoiceType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestSuiteTestVoiceType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => TestSuiteTestVoiceType.Voice,
                _ => null,
            };
        }
    }
}