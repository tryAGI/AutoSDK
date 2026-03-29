//HintName: G.Models.CreateTaskRequestVariant7Type.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateTaskRequestVariant7Type
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="animate_retarget")]
        AnimateRetarget,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateTaskRequestVariant7TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateTaskRequestVariant7Type value)
        {
            return value switch
            {
                CreateTaskRequestVariant7Type.AnimateRetarget => "animate_retarget",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateTaskRequestVariant7Type? ToEnum(string value)
        {
            return value switch
            {
                "animate_retarget" => CreateTaskRequestVariant7Type.AnimateRetarget,
                _ => null,
            };
        }
    }
}