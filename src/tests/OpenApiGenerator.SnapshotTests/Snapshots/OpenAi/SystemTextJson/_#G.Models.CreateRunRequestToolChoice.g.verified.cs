//HintName: G.Models.CreateRunRequestToolChoice.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// `none` means the model will not call any tools and instead generates a message. `auto` means the model can pick between generating a message or calling one or more tools. `required` means the model must call one or more tools before responding to the user.
    /// </summary>
    public abstract class CreateRunRequestToolChoice
    {
        /// <summary>
        /// 
        /// </summary>
        public const string None = "none";
        /// <summary>
        /// 
        /// </summary>
        public const string Auto = "auto";
        /// <summary>
        /// 
        /// </summary>
        public const string Required = "required";
    }
}