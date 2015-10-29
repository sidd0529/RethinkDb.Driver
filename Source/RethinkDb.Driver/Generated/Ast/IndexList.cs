












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class IndexList : ReqlExpr {

    
    
    
/// <summary>
/// <para>List all the secondary indexes of this table.</para>
/// </summary>
/// <example><para>Example: List the available secondary indexes for this table.</para>
/// <code>r.table('marvel').indexList().run(conn, callback)
/// </code></example>
        public IndexList (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>List all the secondary indexes of this table.</para>
/// </summary>
/// <example><para>Example: List the available secondary indexes for this table.</para>
/// <code>r.table('marvel').indexList().run(conn, callback)
/// </code></example>
        public IndexList (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>List all the secondary indexes of this table.</para>
/// </summary>
/// <example><para>Example: List the available secondary indexes for this table.</para>
/// <code>r.table('marvel').indexList().run(conn, callback)
/// </code></example>
        public IndexList (Arguments args, object optargs)
             : this(TermType.INDEX_LIST, args, optargs) {
        }

    protected IndexList (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
