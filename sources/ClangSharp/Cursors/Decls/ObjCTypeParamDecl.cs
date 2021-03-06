// Copyright (c) Microsoft and Contributors. All rights reserved. Licensed under the University of Illinois/NCSA Open Source License. See LICENSE.txt in the project root for license information.

using ClangSharp.Interop;

namespace ClangSharp
{
    public sealed class ObjCTypeParamDecl : TypedefNameDecl
    {
        internal ObjCTypeParamDecl(CXCursor handle) : base(handle, CXCursorKind.CXCursor_UnexposedDecl, CX_DeclKind.CX_DeclKind_ObjCTypeParam)
        {
        }

        public uint Index => unchecked((uint)Handle.TemplateTypeParmIndex);
    }
}
