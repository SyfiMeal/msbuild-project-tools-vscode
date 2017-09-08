namespace MSBuildProjectTools.LanguageServer.SemanticModel.MSBuildExpressions
{
    /// <summary>
    ///     Well-known kinds of MSBuild expression nodes.
    /// </summary>
    public enum ExpressionKind
    {
        /// <summary>
        ///     A semicolon-delimited list of simple items.
        /// </summary>
        SimpleList,

        /// <summary>
        ///     A simple list item.
        /// </summary>
        SimpleListItem,

        /// <summary>
        ///     A simple list item separator.
        /// </summary>
        SimpleListSeparator,

        /// <summary>
        ///     A semicolon-delimited list of expressions.
        /// </summary>
        List,

        /// <summary>
        ///     Placeholder representing an empty slot in an expression list.
        /// </summary>
        EmptyListItem,

        /// <summary>
        ///     A quoted string.
        /// </summary>
        QuotedString,

        /// <summary>
        ///     A comparison expression.
        /// </summary>
        Comparison,

        /// <summary>
        ///     A generic symbol.
        /// </summary>
        Symbol
    }

    /// <summary>
    ///     Represents a kind of MSBuild comparison expression.
    /// </summary>
    public enum ComparisonKind
    {
        /// <summary>
        ///     Equality ("==").
        /// </summary>
        Equality,

        /// <summary>
        ///     Inequality ("!=").
        /// </summary>
        Inequality
    }
}
