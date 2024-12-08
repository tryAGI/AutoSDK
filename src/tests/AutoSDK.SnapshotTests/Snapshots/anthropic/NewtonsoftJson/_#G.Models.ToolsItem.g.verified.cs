//HintName: G.Models.ToolsItem.g.cs
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace G
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct ToolsItem : global::System.IEquatable<ToolsItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::G.BetaCountMessageTokensParamsToolDiscriminatorType? Type { get; }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaTool? Custom { get; init; }
#else
        public global::G.BetaTool? Custom { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Custom))]
#endif
        public bool IsCustom => Custom != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::G.BetaTool value) => new ToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaTool?(ToolsItem @this) => @this.Custom;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::G.BetaTool? value)
        {
            Custom = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaComputerUseTool20241022? Computer20241022 { get; init; }
#else
        public global::G.BetaComputerUseTool20241022? Computer20241022 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Computer20241022))]
#endif
        public bool IsComputer20241022 => Computer20241022 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::G.BetaComputerUseTool20241022 value) => new ToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaComputerUseTool20241022?(ToolsItem @this) => @this.Computer20241022;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::G.BetaComputerUseTool20241022? value)
        {
            Computer20241022 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaBashTool20241022? Bash20241022 { get; init; }
#else
        public global::G.BetaBashTool20241022? Bash20241022 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bash20241022))]
#endif
        public bool IsBash20241022 => Bash20241022 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::G.BetaBashTool20241022 value) => new ToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaBashTool20241022?(ToolsItem @this) => @this.Bash20241022;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::G.BetaBashTool20241022? value)
        {
            Bash20241022 = value;
        }

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::G.BetaTextEditor20241022? TextEditor20241022 { get; init; }
#else
        public global::G.BetaTextEditor20241022? TextEditor20241022 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TextEditor20241022))]
#endif
        public bool IsTextEditor20241022 => TextEditor20241022 != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator ToolsItem(global::G.BetaTextEditor20241022 value) => new ToolsItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::G.BetaTextEditor20241022?(ToolsItem @this) => @this.TextEditor20241022;

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(global::G.BetaTextEditor20241022? value)
        {
            TextEditor20241022 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public ToolsItem(
            global::G.BetaCountMessageTokensParamsToolDiscriminatorType? type,
            global::G.BetaTool? custom,
            global::G.BetaComputerUseTool20241022? computer20241022,
            global::G.BetaBashTool20241022? bash20241022,
            global::G.BetaTextEditor20241022? textEditor20241022
            )
        {
            Type = type;

            Custom = custom;
            Computer20241022 = computer20241022;
            Bash20241022 = bash20241022;
            TextEditor20241022 = textEditor20241022;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TextEditor20241022 as object ??
            Bash20241022 as object ??
            Computer20241022 as object ??
            Custom as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCustom && !IsComputer20241022 && !IsBash20241022 && !IsTextEditor20241022 || !IsCustom && IsComputer20241022 && !IsBash20241022 && !IsTextEditor20241022 || !IsCustom && !IsComputer20241022 && IsBash20241022 && !IsTextEditor20241022 || !IsCustom && !IsComputer20241022 && !IsBash20241022 && IsTextEditor20241022;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::G.BetaTool?, TResult>? custom = null,
            global::System.Func<global::G.BetaComputerUseTool20241022?, TResult>? computer20241022 = null,
            global::System.Func<global::G.BetaBashTool20241022?, TResult>? bash20241022 = null,
            global::System.Func<global::G.BetaTextEditor20241022?, TResult>? textEditor20241022 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom && custom != null)
            {
                return custom(Custom!);
            }
            else if (IsComputer20241022 && computer20241022 != null)
            {
                return computer20241022(Computer20241022!);
            }
            else if (IsBash20241022 && bash20241022 != null)
            {
                return bash20241022(Bash20241022!);
            }
            else if (IsTextEditor20241022 && textEditor20241022 != null)
            {
                return textEditor20241022(TextEditor20241022!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::G.BetaTool?>? custom = null,
            global::System.Action<global::G.BetaComputerUseTool20241022?>? computer20241022 = null,
            global::System.Action<global::G.BetaBashTool20241022?>? bash20241022 = null,
            global::System.Action<global::G.BetaTextEditor20241022?>? textEditor20241022 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCustom)
            {
                custom?.Invoke(Custom!);
            }
            else if (IsComputer20241022)
            {
                computer20241022?.Invoke(Computer20241022!);
            }
            else if (IsBash20241022)
            {
                bash20241022?.Invoke(Bash20241022!);
            }
            else if (IsTextEditor20241022)
            {
                textEditor20241022?.Invoke(TextEditor20241022!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Custom,
                typeof(global::G.BetaTool),
                Computer20241022,
                typeof(global::G.BetaComputerUseTool20241022),
                Bash20241022,
                typeof(global::G.BetaBashTool20241022),
                TextEditor20241022,
                typeof(global::G.BetaTextEditor20241022),
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
        public bool Equals(ToolsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::G.BetaTool?>.Default.Equals(Custom, other.Custom) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaComputerUseTool20241022?>.Default.Equals(Computer20241022, other.Computer20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaBashTool20241022?>.Default.Equals(Bash20241022, other.Bash20241022) &&
                global::System.Collections.Generic.EqualityComparer<global::G.BetaTextEditor20241022?>.Default.Equals(TextEditor20241022, other.TextEditor20241022) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(ToolsItem obj1, ToolsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ToolsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(ToolsItem obj1, ToolsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ToolsItem o && Equals(o);
        }
    }
}
