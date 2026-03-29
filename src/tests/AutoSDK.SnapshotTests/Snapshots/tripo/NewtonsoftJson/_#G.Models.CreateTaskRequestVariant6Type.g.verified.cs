//HintName: G.Models.CreateTaskRequestVariant6Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTaskRequestVariant6Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animate_rig")]
        AnimateRig,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant6TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant6Type value)
        {
            return value switch
            {
                CreateTaskRequestVariant6Type.AnimateRig => "animate_rig",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant6Type? ToEnum(string value)
        {
            return value switch
            {
                "animate_rig" => CreateTaskRequestVariant6Type.AnimateRig,
                _ => null,
            };
        }
    }
}