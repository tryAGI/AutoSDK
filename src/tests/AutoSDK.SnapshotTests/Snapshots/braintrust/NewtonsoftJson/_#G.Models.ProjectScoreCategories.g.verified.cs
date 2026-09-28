//HintName: G.Models.ProjectScoreCategories.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ProjectScoreCategories : global::System.IEquatable<ProjectScoreCategories>
    {
        /// <summary>
        /// For categorical-type project scores, the list of all categories
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<global::G.ProjectScoreCategory>? Categorical { get; init; }
#else
        public global::System.Collections.Generic.IList<global::G.ProjectScoreCategory>? Categorical { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Categorical))]
#endif
        public bool IsCategorical => Categorical != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCategorical(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<global::G.ProjectScoreCategory>? value)
        {
            value = Categorical;
            return IsCategorical;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<global::G.ProjectScoreCategory> PickCategorical() => Categorical is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Categorical' but the value was {ToString()}.");

        /// <summary>
        /// For weighted-type project scores, the weights of each score
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.Dictionary<string, double>? Weighted { get; init; }
#else
        public global::System.Collections.Generic.Dictionary<string, double>? Weighted { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Weighted))]
#endif
        public bool IsWeighted => Weighted != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickWeighted(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.Dictionary<string, double>? value)
        {
            value = Weighted;
            return IsWeighted;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double> PickWeighted() => Weighted is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Weighted' but the value was {ToString()}.");

        /// <summary>
        /// For minimum-type project scores, the list of included scores
        /// </summary>
#if NET6_0_OR_GREATER
        public global::System.Collections.Generic.IList<string>? Minimum { get; init; }
#else
        public global::System.Collections.Generic.IList<string>? Minimum { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Minimum))]
#endif
        public bool IsMinimum => Minimum != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickMinimum(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::System.Collections.Generic.IList<string>? value)
        {
            value = Minimum;
            return IsMinimum;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::System.Collections.Generic.IList<string> PickMinimum() => Minimum is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Minimum' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public object? ProjectScoreCategoriesVariant4 { get; init; }
#else
        public object? ProjectScoreCategoriesVariant4 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ProjectScoreCategoriesVariant4))]
#endif
        public bool IsProjectScoreCategoriesVariant4 => ProjectScoreCategoriesVariant4 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickProjectScoreCategoriesVariant4(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out object? value)
        {
            value = ProjectScoreCategoriesVariant4;
            return IsProjectScoreCategoriesVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object PickProjectScoreCategoriesVariant4() => ProjectScoreCategoriesVariant4 is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'ProjectScoreCategoriesVariant4' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ProjectScoreCategories(global::System.Collections.Generic.Dictionary<string, double> value) => new ProjectScoreCategories((global::System.Collections.Generic.Dictionary<string, double>?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::System.Collections.Generic.Dictionary<string, double>?(ProjectScoreCategories @this) => @this.Weighted;

        /// <summary>
        /// 
        /// </summary>
        public ProjectScoreCategories(global::System.Collections.Generic.Dictionary<string, double>? value)
        {
            Weighted = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static ProjectScoreCategories FromWeighted(global::System.Collections.Generic.Dictionary<string, double>? value) => new ProjectScoreCategories(value);

        /// <summary>
        /// 
        /// </summary>
        public ProjectScoreCategories(
            global::System.Collections.Generic.IList<global::G.ProjectScoreCategory>? categorical,
            global::System.Collections.Generic.Dictionary<string, double>? weighted,
            global::System.Collections.Generic.IList<string>? minimum,
            object? projectScoreCategoriesVariant4
            )
        {
            Categorical = categorical;
            Weighted = weighted;
            Minimum = minimum;
            ProjectScoreCategoriesVariant4 = projectScoreCategoriesVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ProjectScoreCategoriesVariant4 as object ??
            Minimum as object ??
            Weighted as object ??
            Categorical as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            Categorical?.ToString() ??
            Weighted?.ToString() ??
            Minimum?.ToString() ??
            ProjectScoreCategoriesVariant4?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCategorical || IsWeighted || IsMinimum || IsProjectScoreCategoriesVariant4;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::System.Collections.Generic.IList<global::G.ProjectScoreCategory>, TResult>? categorical = null,
            global::System.Func<global::System.Collections.Generic.Dictionary<string, double>, TResult>? weighted = null,
            global::System.Func<global::System.Collections.Generic.IList<string>, TResult>? minimum = null,
            global::System.Func<object, TResult>? projectScoreCategoriesVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Categorical is { } __value0 && categorical != null)
            {
                return categorical(__value0);
            }
            else if (Weighted is { } __value1 && weighted != null)
            {
                return weighted(__value1);
            }
            else if (Minimum is { } __value2 && minimum != null)
            {
                return minimum(__value2);
            }
            else if (ProjectScoreCategoriesVariant4 is { } __value3 && projectScoreCategoriesVariant4 != null)
            {
                return projectScoreCategoriesVariant4(__value3);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::System.Collections.Generic.IList<global::G.ProjectScoreCategory>>? categorical = null,

            global::System.Action<global::System.Collections.Generic.Dictionary<string, double>>? weighted = null,

            global::System.Action<global::System.Collections.Generic.IList<string>>? minimum = null,

            global::System.Action<object>? projectScoreCategoriesVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Categorical is { } __value0)
            {
                categorical?.Invoke(__value0);
            }
            else if (Weighted is { } __value1)
            {
                weighted?.Invoke(__value1);
            }
            else if (Minimum is { } __value2)
            {
                minimum?.Invoke(__value2);
            }
            else if (ProjectScoreCategoriesVariant4 is { } __value3)
            {
                projectScoreCategoriesVariant4?.Invoke(__value3);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::System.Collections.Generic.IList<global::G.ProjectScoreCategory>>? categorical = null,
            global::System.Action<global::System.Collections.Generic.Dictionary<string, double>>? weighted = null,
            global::System.Action<global::System.Collections.Generic.IList<string>>? minimum = null,
            global::System.Action<object>? projectScoreCategoriesVariant4 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Categorical is { } __value0)
            {
                categorical?.Invoke(__value0);
            }
            else if (Weighted is { } __value1)
            {
                weighted?.Invoke(__value1);
            }
            else if (Minimum is { } __value2)
            {
                minimum?.Invoke(__value2);
            }
            else if (ProjectScoreCategoriesVariant4 is { } __value3)
            {
                projectScoreCategoriesVariant4?.Invoke(__value3);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Categorical,
                typeof(global::System.Collections.Generic.IList<global::G.ProjectScoreCategory>),
                Weighted,
                typeof(global::System.Collections.Generic.Dictionary<string, double>),
                Minimum,
                typeof(global::System.Collections.Generic.IList<string>),
                ProjectScoreCategoriesVariant4,
                typeof(object),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(ProjectScoreCategories other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<global::G.ProjectScoreCategory>?>.Default.Equals(Categorical, other.Categorical) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.Dictionary<string, double>?>.Default.Equals(Weighted, other.Weighted) &&
                global::System.Collections.Generic.EqualityComparer<global::System.Collections.Generic.IList<string>?>.Default.Equals(Minimum, other.Minimum) &&
                global::System.Collections.Generic.EqualityComparer<object?>.Default.Equals(ProjectScoreCategoriesVariant4, other.ProjectScoreCategoriesVariant4) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ProjectScoreCategories obj1, ProjectScoreCategories obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ProjectScoreCategories>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ProjectScoreCategories obj1, ProjectScoreCategories obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ProjectScoreCategories o && Equals(o);
        }
    }
}
