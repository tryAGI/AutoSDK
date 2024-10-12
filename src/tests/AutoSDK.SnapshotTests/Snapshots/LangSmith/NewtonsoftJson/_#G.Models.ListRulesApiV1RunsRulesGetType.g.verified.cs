//HintName: G.Models.ListRulesApiV1RunsRulesGetType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ListRulesApiV1RunsRulesGetType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="session")]
        Session,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListRulesApiV1RunsRulesGetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListRulesApiV1RunsRulesGetType value)
        {
            return value switch
            {
                ListRulesApiV1RunsRulesGetType.Session => "session",
                ListRulesApiV1RunsRulesGetType.Dataset => "dataset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListRulesApiV1RunsRulesGetType? ToEnum(string value)
        {
            return value switch
            {
                "session" => ListRulesApiV1RunsRulesGetType.Session,
                "dataset" => ListRulesApiV1RunsRulesGetType.Dataset,
                _ => null,
            };
        }
    }
}