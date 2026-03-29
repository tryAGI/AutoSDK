//HintName: G.Models.ScopeEnum.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// * `Organization` - Organization<br/>
    /// * `User` - User<br/>
    /// * `Model` - Model
    /// </summary>
    public enum ScopeEnum
    {
        /// <summary>
        /// 
        /// </summary>
        Model,
        /// <summary>
        /// 
        /// </summary>
        Organization,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ScopeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ScopeEnum value)
        {
            return value switch
            {
                ScopeEnum.Model => "Model",
                ScopeEnum.Organization => "Organization",
                ScopeEnum.User => "User",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ScopeEnum? ToEnum(string value)
        {
            return value switch
            {
                "Model" => ScopeEnum.Model,
                "Organization" => ScopeEnum.Organization,
                "User" => ScopeEnum.User,
                _ => null,
            };
        }
    }
}