//HintName: G.Models.UpdateTestSuiteTestVoiceDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the test, which must be voice.
    /// </summary>
    public enum UpdateTestSuiteTestVoiceDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateTestSuiteTestVoiceDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateTestSuiteTestVoiceDtoType value)
        {
            return value switch
            {
                UpdateTestSuiteTestVoiceDtoType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateTestSuiteTestVoiceDtoType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => UpdateTestSuiteTestVoiceDtoType.Voice,
                _ => null,
            };
        }
    }
}