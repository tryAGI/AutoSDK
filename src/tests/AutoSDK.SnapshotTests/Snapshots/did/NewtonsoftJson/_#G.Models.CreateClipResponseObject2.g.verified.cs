//HintName: G.Models.CreateClipResponseObject2.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// An identifier of this clip
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateClipResponseObject2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="clip")]
        Clip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateClipResponseObject2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateClipResponseObject2 value)
        {
            return value switch
            {
                CreateClipResponseObject2.Clip => "clip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateClipResponseObject2? ToEnum(string value)
        {
            return value switch
            {
                "clip" => CreateClipResponseObject2.Clip,
                _ => null,
            };
        }
    }
}