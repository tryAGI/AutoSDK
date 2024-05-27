//HintName: G.Models.CreateModelsRequestVisibility.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Whether the model should be public or private. A public model can be viewed and run by anyone, whereas a private model can be viewed and run only by the user or organization members that own the model.
    /// </summary>
    public abstract class CreateModelsRequestVisibility
    {
        /// <summary>
        /// 
        /// </summary>
        public const string Public = "public";
        /// <summary>
        /// 
        /// </summary>
        public const string Private = "private";
    }
}