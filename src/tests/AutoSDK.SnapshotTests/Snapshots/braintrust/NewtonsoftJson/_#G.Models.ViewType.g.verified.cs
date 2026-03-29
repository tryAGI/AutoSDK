//HintName: G.Models.ViewType.g.cs

#nullable enable

namespace G
{
    /// <summary>
    /// Type of object that the view corresponds to.
    /// </summary>
    [global::System.Runtime.Serialization.DataContract]
    public enum ViewType
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
    public static class ViewTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ViewType value)
        {
            return value switch
            {
                ViewType.Classifiers => "classifiers",
                ViewType.Dataset => "dataset",
                ViewType.Datasets => "datasets",
                ViewType.Experiment => "experiment",
                ViewType.Experiments => "experiments",
                ViewType.ForReviewDatasets => "for_review_datasets",
                ViewType.ForReviewExperiments => "for_review_experiments",
                ViewType.ForReviewProjectLog => "for_review_project_log",
                ViewType.Logs => "logs",
                ViewType.Monitor => "monitor",
                ViewType.Parameters => "parameters",
                ViewType.Playground => "playground",
                ViewType.Playgrounds => "playgrounds",
                ViewType.Projects => "projects",
                ViewType.Prompts => "prompts",
                ViewType.Scorers => "scorers",
                ViewType.Tools => "tools",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ViewType? ToEnum(string value)
        {
            return value switch
            {
                "classifiers" => ViewType.Classifiers,
                "dataset" => ViewType.Dataset,
                "datasets" => ViewType.Datasets,
                "experiment" => ViewType.Experiment,
                "experiments" => ViewType.Experiments,
                "for_review_datasets" => ViewType.ForReviewDatasets,
                "for_review_experiments" => ViewType.ForReviewExperiments,
                "for_review_project_log" => ViewType.ForReviewProjectLog,
                "logs" => ViewType.Logs,
                "monitor" => ViewType.Monitor,
                "parameters" => ViewType.Parameters,
                "playground" => ViewType.Playground,
                "playgrounds" => ViewType.Playgrounds,
                "projects" => ViewType.Projects,
                "prompts" => ViewType.Prompts,
                "scorers" => ViewType.Scorers,
                "tools" => ViewType.Tools,
                _ => null,
            };
        }
    }
}