//HintName: G.Models.CreateModelsRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateModelsRequestVisibility
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
    public static class CreateModelsRequestVisibilityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateModelsRequestVisibility value)
        {
            return value switch
            {
                CreateModelsRequestVisibility.Public => "public",
                CreateModelsRequestVisibility.Private => "private",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateModelsRequestVisibility ToEnum(string value)
        {
            return value switch
            {
                "public" => CreateModelsRequestVisibility.Public,
                "private" => CreateModelsRequestVisibility.Private,
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
    }
}