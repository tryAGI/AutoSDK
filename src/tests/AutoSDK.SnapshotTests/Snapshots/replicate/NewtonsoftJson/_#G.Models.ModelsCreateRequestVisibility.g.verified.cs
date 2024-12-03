//HintName: G.Models.ModelsCreateRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ModelsCreateRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="public")]
        Public,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="private")]
        Private,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelsCreateRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelsCreateRequestVisibility value)
        {
            return value switch
            {
                ModelsCreateRequestVisibility.Public => "public",
                ModelsCreateRequestVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelsCreateRequestVisibility? ToEnum(string value)
        {
            return value switch
            {
                "public" => ModelsCreateRequestVisibility.Public,
                "private" => ModelsCreateRequestVisibility.Private,
                _ => null,
            };
        }
    }
}