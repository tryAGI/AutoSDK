//HintName: G.Models.IngestionEventVariant2Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum IngestionEventVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="score-create")]
        ScoreCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class IngestionEventVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this IngestionEventVariant2Type value)
        {
            return value switch
            {
                IngestionEventVariant2Type.ScoreCreate => "score-create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static IngestionEventVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "score-create" => IngestionEventVariant2Type.ScoreCreate,
                _ => null,
            };
        }
    }
}