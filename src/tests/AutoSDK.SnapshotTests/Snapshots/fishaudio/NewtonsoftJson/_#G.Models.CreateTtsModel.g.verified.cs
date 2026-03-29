//HintName: G.Models.CreateTtsModel.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: s2-pro
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTtsModel
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s1")]
        S1,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="s2-pro")]
        S2Pro,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTtsModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTtsModel value)
        {
            return value switch
            {
                CreateTtsModel.S1 => "s1",
                CreateTtsModel.S2Pro => "s2-pro",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTtsModel? ToEnum(string value)
        {
            return value switch
            {
                "s1" => CreateTtsModel.S1,
                "s2-pro" => CreateTtsModel.S2Pro,
                _ => null,
            };
        }
    }
}