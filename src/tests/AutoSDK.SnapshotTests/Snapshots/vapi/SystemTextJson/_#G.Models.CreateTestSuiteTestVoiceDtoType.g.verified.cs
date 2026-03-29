//HintName: G.Models.CreateTestSuiteTestVoiceDtoType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// This is the type of the test, which must be voice.
    /// </summary>
    public enum CreateTestSuiteTestVoiceDtoType
    {
        /// <summary>
        /// 
        /// </summary>
        Voice,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTestSuiteTestVoiceDtoTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTestSuiteTestVoiceDtoType value)
        {
            return value switch
            {
                CreateTestSuiteTestVoiceDtoType.Voice => "voice",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTestSuiteTestVoiceDtoType? ToEnum(string value)
        {
            return value switch
            {
                "voice" => CreateTestSuiteTestVoiceDtoType.Voice,
                _ => null,
            };
        }
    }
}