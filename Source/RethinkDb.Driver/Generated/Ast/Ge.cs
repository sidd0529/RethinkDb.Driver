












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

    public class Ge : ReqlExpr {

    
    
    
/// <summary>
/// <para>Test if the first value is greater than or equal to other.</para>
/// </summary>
/// <example><para>Example: Is 2 greater than or equal to 2?</para>
/// <code>r.expr(2).ge(2).run(conn, callback)
/// </code></example>
        public Ge (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Test if the first value is greater than or equal to other.</para>
/// </summary>
/// <example><para>Example: Is 2 greater than or equal to 2?</para>
/// <code>r.expr(2).ge(2).run(conn, callback)
/// </code></example>
        public Ge (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Test if the first value is greater than or equal to other.</para>
/// </summary>
/// <example><para>Example: Is 2 greater than or equal to 2?</para>
/// <code>r.expr(2).ge(2).run(conn, callback)
/// </code></example>
        public Ge (Arguments args, object optargs)
             : this(TermType.GE, args, optargs) {
        }

    protected Ge (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
