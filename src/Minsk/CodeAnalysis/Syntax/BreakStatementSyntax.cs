namespace Minsk.CodeAnalysis.Syntax
{
    internal sealed partial class BreakStatementSyntax : StatementSyntax
    {
        public BreakStatementSyntax(SyntaxTree syntaxTree, SyntaxToken keyword)
            : base(syntaxTree)
        {
            Keyword = keyword;
        }

        public override SyntaxKind Kind => SyntaxKind.BreakStatement;
        public SyntaxToken Keyword { get; }
    }
}