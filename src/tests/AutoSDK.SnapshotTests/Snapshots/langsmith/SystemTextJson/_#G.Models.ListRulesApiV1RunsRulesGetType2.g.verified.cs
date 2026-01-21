//HintName: G.Models.ListRulesApiV1RunsRulesGetType2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListRulesApiV1RunsRulesGetType2
    {
        /// <summary>
        /// 
        /// </summary>
        Session,
        /// <summary>
        /// 
        /// </summary>
        Dataset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRulesApiV1RunsRulesGetType2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRulesApiV1RunsRulesGetType2 value)
        {
            return value switch
            {
                ListRulesApiV1RunsRulesGetType2.Session => "session",
                ListRulesApiV1RunsRulesGetType2.Dataset => "dataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRulesApiV1RunsRulesGetType2? ToEnum(string value)
        {
            return value switch
            {
                "session" => ListRulesApiV1RunsRulesGetType2.Session,
                "dataset" => ListRulesApiV1RunsRulesGetType2.Dataset,
                _ => null,
            };
        }
    }
}