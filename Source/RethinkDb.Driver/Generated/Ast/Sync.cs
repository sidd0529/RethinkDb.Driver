












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

    public class Sync : ReqlExpr {

    
    
    
/// <summary>
/// <para><code>sync</code> ensures that writes on a given table are written to permanent storage. Queries
/// that specify soft durability (<code>{durability: 'soft'}</code>) do not give such guarantees, so
/// <code>sync</code> can be used to ensure the state of these queries. A call to <code>sync</code> does not return
/// until all previous writes to the table are persisted.</para>
/// </summary>
/// <example><para>Example: After having updated multiple heroes with soft durability, we now want to wait
/// until these changes are persisted.</para>
/// <code>r.table('marvel').sync().run(conn, callback)
/// </code></example>
        public Sync (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para><code>sync</code> ensures that writes on a given table are written to permanent storage. Queries
/// that specify soft durability (<code>{durability: 'soft'}</code>) do not give such guarantees, so
/// <code>sync</code> can be used to ensure the state of these queries. A call to <code>sync</code> does not return
/// until all previous writes to the table are persisted.</para>
/// </summary>
/// <example><para>Example: After having updated multiple heroes with soft durability, we now want to wait
/// until these changes are persisted.</para>
/// <code>r.table('marvel').sync().run(conn, callback)
/// </code></example>
        public Sync (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para><code>sync</code> ensures that writes on a given table are written to permanent storage. Queries
/// that specify soft durability (<code>{durability: 'soft'}</code>) do not give such guarantees, so
/// <code>sync</code> can be used to ensure the state of these queries. A call to <code>sync</code> does not return
/// until all previous writes to the table are persisted.</para>
/// </summary>
/// <example><para>Example: After having updated multiple heroes with soft durability, we now want to wait
/// until these changes are persisted.</para>
/// <code>r.table('marvel').sync().run(conn, callback)
/// </code></example>
        public Sync (Arguments args, object optargs)
             : this(TermType.SYNC, args, optargs) {
        }

    protected Sync (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
