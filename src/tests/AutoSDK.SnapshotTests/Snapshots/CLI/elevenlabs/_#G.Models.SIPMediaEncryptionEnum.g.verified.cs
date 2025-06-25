//HintName: G.Models.SIPMediaEncryptionEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum SIPMediaEncryptionEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Allowed,
        /// <summary>
        /// 
        /// </summary>
        Required,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SIPMediaEncryptionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SIPMediaEncryptionEnum value)
        {
            return value switch
            {
                SIPMediaEncryptionEnum.Disabled => "disabled",
                SIPMediaEncryptionEnum.Allowed => "allowed",
                SIPMediaEncryptionEnum.Required => "required",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SIPMediaEncryptionEnum? ToEnum(string value)
        {
            return value switch
            {
                "disabled" => SIPMediaEncryptionEnum.Disabled,
                "allowed" => SIPMediaEncryptionEnum.Allowed,
                "required" => SIPMediaEncryptionEnum.Required,
                _ => null,
            };
        }
    }
}