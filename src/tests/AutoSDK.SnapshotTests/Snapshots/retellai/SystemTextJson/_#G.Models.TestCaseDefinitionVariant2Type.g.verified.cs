//HintName: G.Models.TestCaseDefinitionVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of test case definition
    /// </summary>
    public enum TestCaseDefinitionVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        Simulation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TestCaseDefinitionVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TestCaseDefinitionVariant2Type value)
        {
            return value switch
            {
                TestCaseDefinitionVariant2Type.Simulation => "simulation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TestCaseDefinitionVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "simulation" => TestCaseDefinitionVariant2Type.Simulation,
                _ => null,
            };
        }
    }
}