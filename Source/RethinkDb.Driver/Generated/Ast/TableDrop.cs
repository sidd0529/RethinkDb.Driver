












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

    public class TableDrop : ReqlExpr {

    
    
    
/// <summary>
/// <para>Drop a table. The table and all its data will be deleted.</para>
/// </summary>
/// <example><para>Example: Drop a table named 'dc_universe'.</para>
/// <code>r.db('test').tableDrop('dc_universe').run(conn, callback)
/// </code></example>
        public TableDrop (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Drop a table. The table and all its data will be deleted.</para>
/// </summary>
/// <example><para>Example: Drop a table named 'dc_universe'.</para>
/// <code>r.db('test').tableDrop('dc_universe').run(conn, callback)
/// </code></example>
        public TableDrop (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Drop a table. The table and all its data will be deleted.</para>
/// </summary>
/// <example><para>Example: Drop a table named 'dc_universe'.</para>
/// <code>r.db('test').tableDrop('dc_universe').run(conn, callback)
/// </code></example>
        public TableDrop (Arguments args, object optargs)
             : this(TermType.TABLE_DROP, args, optargs) {
        }

    protected TableDrop (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
