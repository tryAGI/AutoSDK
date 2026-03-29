//HintName: G.Models.ModalSandboxConfigLanguage.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Default Value: python
    /// </summary>
    public enum ModalSandboxConfigLanguage
    {
        /// <summary>
        /// 
        /// </summary>
        Python,
        /// <summary>
        /// 
        /// </summary>
        Typescript,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModalSandboxConfigLanguageExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModalSandboxConfigLanguage value)
        {
            return value switch
            {
                ModalSandboxConfigLanguage.Python => "python",
                ModalSandboxConfigLanguage.Typescript => "typescript",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModalSandboxConfigLanguage? ToEnum(string value)
        {
            return value switch
            {
                "python" => ModalSandboxConfigLanguage.Python,
                "typescript" => ModalSandboxConfigLanguage.Typescript,
                _ => null,
            };
        }
    }
}