//HintName: G.Models.GraphNodeVariant7Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraphNodeVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="aggregator")]
        Aggregator,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraphNodeVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraphNodeVariant7Type value)
        {
            return value switch
            {
                GraphNodeVariant7Type.Aggregator => "aggregator",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraphNodeVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "aggregator" => GraphNodeVariant7Type.Aggregator,
                _ => null,
            };
        }
    }
}