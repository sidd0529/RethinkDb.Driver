




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Tests conversion to and from the RQL array type

    [TestFixture]
    public class DatumArray : GeneratedTest {

        public DatumArray (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #6
                 /* ExpectedOriginal: [] */
                 var expected_ = r.array();
                 
                 /* Original: r.expr([]) */
                 var obtained = runOrCatch( r.expr(r.array()) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #9
                 /* ExpectedOriginal: [1] */
                 var expected_ = r.array(1L);
                 
                 /* Original: r.expr([1]) */
                 var obtained = runOrCatch( r.expr(r.array(1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #14
                 /* ExpectedOriginal: [1,2,3,4,5] */
                 var expected_ = r.array(1L, 2L, 3L, 4L, 5L);
                 
                 /* Original: r.expr([1,2,3,4,5]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L, 4L, 5L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #19
                 /* ExpectedOriginal: ARRAY */
                 var expected_ = "ARRAY";
                 
                 /* Original: r.expr([]).type_of() */
                 var obtained = runOrCatch( r.expr(r.array()).typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #24
                 /* ExpectedOriginal: [1,2] */
                 var expected_ = "[1,2]";
                 
                 /* Original: r.expr([1, 2]).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).coerceTo("string") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #25
                 /* ExpectedOriginal: [1,2] */
                 var expected_ = "[1,2]";
                 
                 /* Original: r.expr([1, 2]).coerce_to('STRING') */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).coerceTo("STRING") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #28
                 /* ExpectedOriginal: [1, 2] */
                 var expected_ = r.array(1L, 2L);
                 
                 /* Original: r.expr([1, 2]).coerce_to('array') */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).coerceTo("array") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #31
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Cannot coerce ARRAY to NUMBER.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot coerce ARRAY to NUMBER.", r.array(0L));
                 
                 /* Original: r.expr([1, 2]).coerce_to('number') */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).coerceTo("number") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #34
                 /* ExpectedOriginal: {'a':1,'b':2} */
                 var expected_ = r.hashMap("a", 1L).with("b", 2L);
                 
                 /* Original: r.expr([['a', 1], ['b', 2]]).coerce_to('object') */
                 var obtained = runOrCatch( r.expr(r.array(r.array("a", 1L), r.array("b", 2L))).coerceTo("object") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #37
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected array of size 2, but got size 0.') */
                 var expected_ = err("ReqlQueryLogicError", "Expected array of size 2, but got size 0.");
                 
                 /* Original: r.expr([[]]).coerce_to('object') */
                 var obtained = runOrCatch( r.expr(r.array(r.array())).coerceTo("object") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #40
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected array of size 2, but got size 3.') */
                 var expected_ = err("ReqlQueryLogicError", "Expected array of size 2, but got size 3.");
                 
                 /* Original: r.expr([['1',2,3]]).coerce_to('object') */
                 var obtained = runOrCatch( r.expr(r.array(r.array("1", 2L, 3L))).coerceTo("object") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #44
                 /* ExpectedOriginal: [1] */
                 var expected_ = r.array(1L);
                 
                 /* Original: r.expr([r.expr(1)]) */
                 var obtained = runOrCatch( r.expr(r.array(r.expr(1L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #47
                 /* ExpectedOriginal: [1,2,3,4] */
                 var expected_ = r.array(1L, 2L, 3L, 4L);
                 
                 /* Original: r.expr([1,3,4]).insert_at(1, 2) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 3L, 4L)).insertAt(1L, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #49
                 /* ExpectedOriginal: [1,2,3] */
                 var expected_ = r.array(1L, 2L, 3L);
                 
                 /* Original: r.expr([2,3]).insert_at(0, 1) */
                 var obtained = runOrCatch( r.expr(r.array(2L, 3L)).insertAt(0L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #51
                 /* ExpectedOriginal: [1,2,3,4] */
                 var expected_ = r.array(1L, 2L, 3L, 4L);
                 
                 /* Original: r.expr([1,2,3]).insert_at(-1, 4) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).insertAt(-1L, 4L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #53
                 /* ExpectedOriginal: [1,2,3,4] */
                 var expected_ = r.array(1L, 2L, 3L, 4L);
                 
                 /* Original: r.expr([1,2,3]).insert_at(3, 4) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).insertAt(3L, 4L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #55
                 /* ExpectedOriginal: AnythingIsFine */
                 var expected_ = AnythingIsFine;
                 
                 /* Original: r.expr(3).do(lambda x: r.expr([1,2,3]).insert_at(x, 4)) */
                 var obtained = runOrCatch( r.expr(3L).do_(x => r.expr(r.array(1L, 2L, 3L)).insertAt(x, 4L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #59
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Index `4` out of bounds for array of size: `3`.', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Index `4` out of bounds for array of size: `3`.", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).insert_at(4, 5) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).insertAt(4L, 5L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #61
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Index out of bounds: -5', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Index out of bounds: -5", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).insert_at(-5, -1) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).insertAt(-5L, -1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #63
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Number not an integer: 1.5', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Number not an integer: 1.5", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).insert_at(1.5, 1) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).insertAt(1.5, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #65
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Expected type NUMBER but found NULL.', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Expected type NUMBER but found NULL.", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).insert_at(null, 1) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).insertAt((ReqlExpr) null, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #68
                 /* ExpectedOriginal: [1,2,3,4] */
                 var expected_ = r.array(1L, 2L, 3L, 4L);
                 
                 /* Original: r.expr([1,4]).splice_at(1, [2,3]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 4L)).spliceAt(1L, r.array(2L, 3L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #70
                 /* ExpectedOriginal: [1,2,3,4] */
                 var expected_ = r.array(1L, 2L, 3L, 4L);
                 
                 /* Original: r.expr([3,4]).splice_at(0, [1,2]) */
                 var obtained = runOrCatch( r.expr(r.array(3L, 4L)).spliceAt(0L, r.array(1L, 2L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #72
                 /* ExpectedOriginal: [1,2,3,4] */
                 var expected_ = r.array(1L, 2L, 3L, 4L);
                 
                 /* Original: r.expr([1,2]).splice_at(2, [3,4]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).spliceAt(2L, r.array(3L, 4L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #74
                 /* ExpectedOriginal: [1,2,3,4] */
                 var expected_ = r.array(1L, 2L, 3L, 4L);
                 
                 /* Original: r.expr([1,2]).splice_at(-1, [3,4]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).spliceAt(-1L, r.array(3L, 4L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #76
                 /* ExpectedOriginal: AnythingIsFine */
                 var expected_ = AnythingIsFine;
                 
                 /* Original: r.expr(2).do(lambda x: r.expr([1,2]).splice_at(x, [3,4])) */
                 var obtained = runOrCatch( r.expr(2L).do_(x => r.expr(r.array(1L, 2L)).spliceAt(x, r.array(3L, 4L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #80
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Index `3` out of bounds for array of size: `2`.', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Index `3` out of bounds for array of size: `2`.", r.array(0L));
                 
                 /* Original: r.expr([1,2]).splice_at(3, [3,4]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).spliceAt(3L, r.array(3L, 4L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #82
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Index out of bounds: -4', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Index out of bounds: -4", r.array(0L));
                 
                 /* Original: r.expr([1,2]).splice_at(-4, [3,4]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).spliceAt(-4L, r.array(3L, 4L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #84
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Number not an integer: 1.5', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Number not an integer: 1.5", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).splice_at(1.5, [1]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).spliceAt(1.5, r.array(1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #86
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Expected type NUMBER but found NULL.', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Expected type NUMBER but found NULL.", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).splice_at(null, [1]) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).spliceAt((ReqlExpr) null, r.array(1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #88
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type ARRAY but found NUMBER.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type ARRAY but found NUMBER.", r.array(0L));
                 
                 /* Original: r.expr([1,4]).splice_at(1, 2) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 4L)).spliceAt(1L, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #91
                 /* ExpectedOriginal: [2,3,4] */
                 var expected_ = r.array(2L, 3L, 4L);
                 
                 /* Original: r.expr([1,2,3,4]).delete_at(0) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L, 4L)).deleteAt(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #93
                 /* ExpectedOriginal: AnythingIsFine */
                 var expected_ = AnythingIsFine;
                 
                 /* Original: r.expr(0).do(lambda x: r.expr([1,2,3,4]).delete_at(x)) */
                 var obtained = runOrCatch( r.expr(0L).do_(x => r.expr(r.array(1L, 2L, 3L, 4L)).deleteAt(x)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #97
                 /* ExpectedOriginal: [1,2,3] */
                 var expected_ = r.array(1L, 2L, 3L);
                 
                 /* Original: r.expr([1,2,3,4]).delete_at(-1) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L, 4L)).deleteAt(-1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #99
                 /* ExpectedOriginal: [1,4] */
                 var expected_ = r.array(1L, 4L);
                 
                 /* Original: r.expr([1,2,3,4]).delete_at(1,3) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L, 4L)).deleteAt(1L, 3L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #101
                 /* ExpectedOriginal: [1,2,3,4] */
                 var expected_ = r.array(1L, 2L, 3L, 4L);
                 
                 /* Original: r.expr([1,2,3,4]).delete_at(4,4) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L, 4L)).deleteAt(4L, 4L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #103
                 /* ExpectedOriginal: [] */
                 var expected_ = r.array();
                 
                 /* Original: r.expr([]).delete_at(0,0) */
                 var obtained = runOrCatch( r.expr(r.array()).deleteAt(0L, 0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #105
                 /* ExpectedOriginal: [1,4] */
                 var expected_ = r.array(1L, 4L);
                 
                 /* Original: r.expr([1,2,3,4]).delete_at(1,-1) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L, 4L)).deleteAt(1L, -1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #107
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Index `4` out of bounds for array of size: `4`.', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Index `4` out of bounds for array of size: `4`.", r.array(0L));
                 
                 /* Original: r.expr([1,2,3,4]).delete_at(4) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L, 4L)).deleteAt(4L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #109
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Index out of bounds: -5', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Index out of bounds: -5", r.array(0L));
                 
                 /* Original: r.expr([1,2,3,4]).delete_at(-5) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L, 4L)).deleteAt(-5L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #111
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Number not an integer: 1.5', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Number not an integer: 1.5", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).delete_at(1.5) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).deleteAt(1.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #113
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Expected type NUMBER but found NULL.', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Expected type NUMBER but found NULL.", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).delete_at(null) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).deleteAt((ReqlExpr) null) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #116
                 /* ExpectedOriginal: [1,2,3] */
                 var expected_ = r.array(1L, 2L, 3L);
                 
                 /* Original: r.expr([0,2,3]).change_at(0, 1) */
                 var obtained = runOrCatch( r.expr(r.array(0L, 2L, 3L)).changeAt(0L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #118
                 /* ExpectedOriginal: AnythingIsFine */
                 var expected_ = AnythingIsFine;
                 
                 /* Original: r.expr(1).do(lambda x: r.expr([0,2,3]).change_at(0,x)) */
                 var obtained = runOrCatch( r.expr(1L).do_(x => r.expr(r.array(0L, 2L, 3L)).changeAt(0L, x)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #122
                 /* ExpectedOriginal: [1,2,3] */
                 var expected_ = r.array(1L, 2L, 3L);
                 
                 /* Original: r.expr([1,0,3]).change_at(1, 2) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 0L, 3L)).changeAt(1L, 2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #124
                 /* ExpectedOriginal: [1,2,3] */
                 var expected_ = r.array(1L, 2L, 3L);
                 
                 /* Original: r.expr([1,2,0]).change_at(2, 3) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 0L)).changeAt(2L, 3L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #126
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Index `3` out of bounds for array of size: `3`.', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Index `3` out of bounds for array of size: `3`.", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).change_at(3, 4) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).changeAt(3L, 4L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #128
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Index out of bounds: -5', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Index out of bounds: -5", r.array(0L));
                 
                 /* Original: r.expr([1,2,3,4]).change_at(-5, 1) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L, 4L)).changeAt(-5L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #130
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Number not an integer: 1.5', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Number not an integer: 1.5", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).change_at(1.5, 1) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).changeAt(1.5, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/array.yaml, #132
                 /* ExpectedOriginal: err('ReqlNonExistenceError', 'Expected type NUMBER but found NULL.', [0]) */
                 var expected_ = err("ReqlNonExistenceError", "Expected type NUMBER but found NULL.", r.array(0L));
                 
                 /* Original: r.expr([1,2,3]).change_at(null, 1) */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L, 3L)).changeAt((ReqlExpr) null, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
