//HintName: G.Models.UserNameSearchModeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserNameSearchModeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        WholeTree,
        /// <summary>
        /// 
        /// </summary>
        DownLineOnly,
        /// <summary>
        /// 
        /// </summary>
        UpLineOnly,
        /// <summary>
        /// 
        /// </summary>
        UpLineAndDownLine,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserNameSearchModeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserNameSearchModeEnum value)
        {
            return value switch
            {
                UserNameSearchModeEnum.WholeTree => "WholeTree",
                UserNameSearchModeEnum.DownLineOnly => "DownLineOnly",
                UserNameSearchModeEnum.UpLineOnly => "UpLineOnly",
                UserNameSearchModeEnum.UpLineAndDownLine => "UpLineAndDownLine",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserNameSearchModeEnum? ToEnum(string value)
        {
            return value switch
            {
                "WholeTree" => UserNameSearchModeEnum.WholeTree,
                "DownLineOnly" => UserNameSearchModeEnum.DownLineOnly,
                "UpLineOnly" => UserNameSearchModeEnum.UpLineOnly,
                "UpLineAndDownLine" => UserNameSearchModeEnum.UpLineAndDownLine,
                _ => null,
            };
        }
    }
}