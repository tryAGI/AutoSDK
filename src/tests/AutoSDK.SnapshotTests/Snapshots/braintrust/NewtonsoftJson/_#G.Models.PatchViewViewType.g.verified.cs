//HintName: G.Models.PatchViewViewType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object that the view corresponds to.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum PatchViewViewType
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
    public static class PatchViewViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PatchViewViewType value)
        {
            return value switch
            {
                PatchViewViewType.Classifiers => "classifiers",
                PatchViewViewType.Dataset => "dataset",
                PatchViewViewType.Datasets => "datasets",
                PatchViewViewType.Experiment => "experiment",
                PatchViewViewType.Experiments => "experiments",
                PatchViewViewType.ForReviewDatasets => "for_review_datasets",
                PatchViewViewType.ForReviewExperiments => "for_review_experiments",
                PatchViewViewType.ForReviewProjectLog => "for_review_project_log",
                PatchViewViewType.Logs => "logs",
                PatchViewViewType.Monitor => "monitor",
                PatchViewViewType.Parameters => "parameters",
                PatchViewViewType.Playground => "playground",
                PatchViewViewType.Playgrounds => "playgrounds",
                PatchViewViewType.Projects => "projects",
                PatchViewViewType.Prompts => "prompts",
                PatchViewViewType.Scorers => "scorers",
                PatchViewViewType.Tools => "tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PatchViewViewType? ToEnum(string value)
        {
            return value switch
            {
                "classifiers" => PatchViewViewType.Classifiers,
                "dataset" => PatchViewViewType.Dataset,
                "datasets" => PatchViewViewType.Datasets,
                "experiment" => PatchViewViewType.Experiment,
                "experiments" => PatchViewViewType.Experiments,
                "for_review_datasets" => PatchViewViewType.ForReviewDatasets,
                "for_review_experiments" => PatchViewViewType.ForReviewExperiments,
                "for_review_project_log" => PatchViewViewType.ForReviewProjectLog,
                "logs" => PatchViewViewType.Logs,
                "monitor" => PatchViewViewType.Monitor,
                "parameters" => PatchViewViewType.Parameters,
                "playground" => PatchViewViewType.Playground,
                "playgrounds" => PatchViewViewType.Playgrounds,
                "projects" => PatchViewViewType.Projects,
                "prompts" => PatchViewViewType.Prompts,
                "scorers" => PatchViewViewType.Scorers,
                "tools" => PatchViewViewType.Tools,
                _ => null,
            };
        }
    }
}