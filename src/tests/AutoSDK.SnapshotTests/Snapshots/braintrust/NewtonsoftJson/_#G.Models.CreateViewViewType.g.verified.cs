//HintName: G.Models.CreateViewViewType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object that the view corresponds to.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum CreateViewViewType
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="classifiers")]
        Classifiers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="dataset")]
        Dataset,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="datasets")]
        Datasets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiment")]
        Experiment,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="experiments")]
        Experiments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="for_review_datasets")]
        ForReviewDatasets,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="for_review_experiments")]
        ForReviewExperiments,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="for_review_project_log")]
        ForReviewProjectLog,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="logs")]
        Logs,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="monitor")]
        Monitor,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="parameters")]
        Parameters,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playground")]
        Playground,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="playgrounds")]
        Playgrounds,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="projects")]
        Projects,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="prompts")]
        Prompts,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="scorers")]
        Scorers,
        /// <summary>
        /// 
        /// </summary>
        [global::System.Runtime.Serialization.EnumMember(Value="tools")]
        Tools,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateViewViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateViewViewType value)
        {
            return value switch
            {
                CreateViewViewType.Classifiers => "classifiers",
                CreateViewViewType.Dataset => "dataset",
                CreateViewViewType.Datasets => "datasets",
                CreateViewViewType.Experiment => "experiment",
                CreateViewViewType.Experiments => "experiments",
                CreateViewViewType.ForReviewDatasets => "for_review_datasets",
                CreateViewViewType.ForReviewExperiments => "for_review_experiments",
                CreateViewViewType.ForReviewProjectLog => "for_review_project_log",
                CreateViewViewType.Logs => "logs",
                CreateViewViewType.Monitor => "monitor",
                CreateViewViewType.Parameters => "parameters",
                CreateViewViewType.Playground => "playground",
                CreateViewViewType.Playgrounds => "playgrounds",
                CreateViewViewType.Projects => "projects",
                CreateViewViewType.Prompts => "prompts",
                CreateViewViewType.Scorers => "scorers",
                CreateViewViewType.Tools => "tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateViewViewType? ToEnum(string value)
        {
            return value switch
            {
                "classifiers" => CreateViewViewType.Classifiers,
                "dataset" => CreateViewViewType.Dataset,
                "datasets" => CreateViewViewType.Datasets,
                "experiment" => CreateViewViewType.Experiment,
                "experiments" => CreateViewViewType.Experiments,
                "for_review_datasets" => CreateViewViewType.ForReviewDatasets,
                "for_review_experiments" => CreateViewViewType.ForReviewExperiments,
                "for_review_project_log" => CreateViewViewType.ForReviewProjectLog,
                "logs" => CreateViewViewType.Logs,
                "monitor" => CreateViewViewType.Monitor,
                "parameters" => CreateViewViewType.Parameters,
                "playground" => CreateViewViewType.Playground,
                "playgrounds" => CreateViewViewType.Playgrounds,
                "projects" => CreateViewViewType.Projects,
                "prompts" => CreateViewViewType.Prompts,
                "scorers" => CreateViewViewType.Scorers,
                "tools" => CreateViewViewType.Tools,
                _ => null,
            };
        }
    }
}