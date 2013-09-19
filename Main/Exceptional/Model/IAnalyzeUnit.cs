// Copyright (c) 2009-2010 Cofinite Solutions. All rights reserved.
using CodeGears.ReSharper.Exceptional.Analyzers;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.ReSharper.Psi.Tree;

namespace CodeGears.ReSharper.Exceptional.Model
{
    internal interface IAnalyzeUnit : IBlockModel
    {
        DocCommentBlockModel DocCommentBlockModel { get; set; }
        bool IsPublicOrInternal { get; }
        IDocCommentBlockNode AddDocCommentNode(IDocCommentBlockNode docCommentBlockNode);
        IPsiModule GetPsiModule();
        void Accept(AnalyzerBase analyzerBase);
    }
}