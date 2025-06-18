//HintName: G.Models.GraderMultiType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// The object type, which is always `multi`.<br/>
    /// Default Value: multi
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum GraderMultiType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="multi")]
        Multi,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GraderMultiTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GraderMultiType value)
        {
            return value switch
            {
                GraderMultiType.Multi => "multi",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GraderMultiType? ToEnum(string value)
        {
            return value switch
            {
                "multi" => GraderMultiType.Multi,
                _ => null,
            };
        }
    }
}