












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

    public class Sub : ReqlExpr {

    
    
    
/// <summary>
/// <para>Subtract two numbers.</para>
/// </summary>
/// <example><para>Example: It's as easy as 2 - 2 = 0.</para>
/// <code>r.expr(2).sub(2).run(conn, callback)
/// </code></example>
        public Sub (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Subtract two numbers.</para>
/// </summary>
/// <example><para>Example: It's as easy as 2 - 2 = 0.</para>
/// <code>r.expr(2).sub(2).run(conn, callback)
/// </code></example>
        public Sub (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Subtract two numbers.</para>
/// </summary>
/// <example><para>Example: It's as easy as 2 - 2 = 0.</para>
/// <code>r.expr(2).sub(2).run(conn, callback)
/// </code></example>
        public Sub (Arguments args, object optargs)
             : this(TermType.SUB, args, optargs) {
        }

    protected Sub (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
