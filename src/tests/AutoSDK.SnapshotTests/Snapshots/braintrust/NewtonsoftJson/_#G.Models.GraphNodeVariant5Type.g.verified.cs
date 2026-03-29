//HintName: G.Models.GraphNodeVariant5Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphNodeVariant5Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="btql")]
        Btql,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphNodeVariant5TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphNodeVariant5Type value)
        {
            return value switch
            {
                GraphNodeVariant5Type.Btql => "btql",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphNodeVariant5Type? ToEnum(string value)
        {
            return value switch
            {
                "btql" => GraphNodeVariant5Type.Btql,
                _ => null,
            };
        }
    }
}