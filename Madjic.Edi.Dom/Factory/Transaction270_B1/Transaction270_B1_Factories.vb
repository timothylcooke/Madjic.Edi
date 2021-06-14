﻿Namespace Factory.Transaction270_B1
    '''<summary>Provides methods for instantiating the Transaction270_B1 transaction sets.</summary>
    Public NotInheritable Class TransactionSetFactory

        Private Sub New()

        End Sub

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet">Transaction270_B1.TransactionSet</see> interface.
        ''' </summary>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet">Transaction270_B1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction270_B1() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Standard_Obj("005010X279A1")
        End Function

        ''' <summary>
        ''' Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet">Transaction270_B1.TransactionSet</see> interface.
        ''' </summary>
        ''' <param name="controlNumber">The control number for this transaction set (carried in ST02).</param>
        ''' <returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet">Transaction270_B1.TransactionSet</see> interface.</returns>
        Public Shared Function CreateTransaction270_B1(controlNumber As String) As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.TransactionSet
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Standard_Obj(controlNumber, "005010X279A1")
        End Function

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.ST">ST</see> interface (Transaction Set Header).</summary>
        Public Shared Function CreateST() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.ST
            Return New Global.Madjic.Edi.Dom.Segments.ST_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.BHT">BHT</see> interface (Beginning of Hierarchical Transaction).</summary>
        Public Shared Function CreateBHT() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.BHT
            Return New Global.Madjic.Edi.Dom.Segments.BHT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.SE">SE</see> interface (Transaction Set Trailer).</summary>
        Public Shared Function CreateSE() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.SE
            Return New Global.Madjic.Edi.Dom.Segments.SE_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A">Loop2000A</see> interface (Information Source Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A">Loop2000A</see> interface.</returns>
        Public Shared Function CreateLoop2000A() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A">Loop2100A</see> interface (Information Source Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A">Loop2100A</see> interface.</returns>
        Public Shared Function CreateLoop2100A() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100A
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B">Loop2000B</see> interface (Information Receiver Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B">Loop2000B</see> interface.</returns>
        Public Shared Function CreateLoop2000B() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B">Loop2100B</see> interface (Information Receiver Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B">Loop2100B</see> interface.</returns>
        Public Shared Function CreateLoop2100B() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100B
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C">Loop2000C</see> interface (Subscriber Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C">Loop2000C</see> interface.</returns>
        Public Shared Function CreateLoop2000C() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C">Loop2100C</see> interface (Subscriber Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C">Loop2100C</see> interface.</returns>
        Public Shared Function CreateLoop2100C() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C">Loop2110C</see> interface (Subscriber Eligibility or Benefit Inquiry).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C">Loop2110C</see> interface.</returns>
        Public Shared Function CreateLoop2110C() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110C
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2110_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D">Loop2000D</see> interface (Dependent Level).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D">Loop2000D</see> interface.</returns>
        Public Shared Function CreateLoop2000D() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2000D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2000_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D">Loop2100D</see> interface (Dependent Name).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D">Loop2100D</see> interface.</returns>
        Public Shared Function CreateLoop2100D() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2100D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2100_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D">Loop2110D</see> interface (Dependent Eligibility or Benefit Inquiry).</summary>
        '''<returns>An object that implements the <see cref="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D">Loop2110D</see> interface.</returns>
        Public Shared Function CreateLoop2110D() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Loops.Loop2110D
            Return New Global.Madjic.Edi.Dom.Transactions.Transaction270.Loop2110_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000A loop (Information Source Level).</summary>
    Public NotInheritable Class Loop2000AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL">HL</see> interface (Information Source Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000A.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100A loop (Information Source Name).</summary>
    Public NotInheritable Class Loop2100AFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100A.NM1">NM1</see> interface (Information Source Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100A.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000B loop (Information Receiver Level).</summary>
    Public NotInheritable Class Loop2000BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL">HL</see> interface (Information Receiver Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000B.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100B loop (Information Receiver Name).</summary>
    Public NotInheritable Class Loop2100BFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.NM1">NM1</see> interface (Information Receiver Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.REF">REF</see> interface (Information Receiver Additional Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N3">N3</see> interface (Information Receiver Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4">N4</see> interface (Information Receiver City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV">PRV</see> interface (Information Receiver Provider Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100B.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000C loop (Subscriber Level).</summary>
    Public NotInheritable Class Loop2000CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL">HL</see> interface (Subscriber Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN">TRN</see> interface (Subscriber Trace Number).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000C.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100C loop (Subscriber Name).</summary>
    Public NotInheritable Class Loop2100CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.NM1">NM1</see> interface (Subscriber Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.REF">REF</see> interface (Subscriber Additional Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N3">N3</see> interface (Subscriber Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4">N4</see> interface (Subscriber City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV">PRV</see> interface (Provider Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG">DMG</see> interface (Subscriber Demographic Information).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS">INS</see> interface (Multiple Birth Sequence Number).</summary>
        Public Shared Function CreateINS() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.INS
            Return New Global.Madjic.Edi.Dom.Segments.INS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI">HI</see> interface (Subscriber Health Care Diagnosis Code).</summary>
        Public Shared Function CreateHI() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.HI
            Return New Global.Madjic.Edi.Dom.Segments.HI_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DTP">DTP</see> interface (Subscriber Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100C.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2110C loop (Subscriber Eligibility or Benefit Inquiry).</summary>
    Public NotInheritable Class Loop2110CFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ">EQ</see> interface (Subscriber Eligibility or Benefit Inquiry).</summary>
        Public Shared Function CreateEQ() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.EQ
            Return New Global.Madjic.Edi.Dom.Segments.EQ_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT">AMT</see> interface (Subscriber Spend Down Amount).</summary>
        Public Shared Function CreateAMT() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1">AMT_1</see> interface (Subscriber Spend Down Total Billed Amount).</summary>
        Public Shared Function CreateAMT_1() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.AMT_1
            Return New Global.Madjic.Edi.Dom.Segments.AMT_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III">III</see> interface (Subscriber Eligibility or Benefit Additional Inquiry Information).</summary>
        Public Shared Function CreateIII() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.III
            Return New Global.Madjic.Edi.Dom.Segments.III_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.REF">REF</see> interface (Subscriber Additional Information).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.DTP">DTP</see> interface (Subscriber Eligibility/Benefit Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110C.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2000D loop (Dependent Level).</summary>
    Public NotInheritable Class Loop2000DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL">HL</see> interface (Dependent Level).</summary>
        Public Shared Function CreateHL() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.HL
            Return New Global.Madjic.Edi.Dom.Segments.HL_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN">TRN</see> interface (Dependent Trace Number).</summary>
        Public Shared Function CreateTRN() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2000D.TRN
            Return New Global.Madjic.Edi.Dom.Segments.TRN_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2100D loop (Dependent Name).</summary>
    Public NotInheritable Class Loop2100DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.NM1">NM1</see> interface (Dependent Name).</summary>
        Public Shared Function CreateNM1() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.NM1
            Return New Global.Madjic.Edi.Dom.Segments.NM1_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.REF">REF</see> interface (Dependent Additional Identification).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N3">N3</see> interface (Dependent Address).</summary>
        Public Shared Function CreateN3() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N3
            Return New Global.Madjic.Edi.Dom.Segments.N3_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4">N4</see> interface (Dependent City, State, ZIP Code).</summary>
        Public Shared Function CreateN4() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.N4
            Return New Global.Madjic.Edi.Dom.Segments.N4_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV">PRV</see> interface (Provider Information).</summary>
        Public Shared Function CreatePRV() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.PRV
            Return New Global.Madjic.Edi.Dom.Segments.PRV_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG">DMG</see> interface (Dependent Demographic Information).</summary>
        Public Shared Function CreateDMG() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DMG
            Return New Global.Madjic.Edi.Dom.Segments.DMG_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS">INS</see> interface (Dependent Relationship).</summary>
        Public Shared Function CreateINS() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.INS
            Return New Global.Madjic.Edi.Dom.Segments.INS_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI">HI</see> interface (Dependent Health Care Diagnosis Code).</summary>
        Public Shared Function CreateHI() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.HI
            Return New Global.Madjic.Edi.Dom.Segments.HI_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DTP">DTP</see> interface (Dependent Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2100D.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class

    '''<summary>Provides methods for instantiating the segments contained in the Loop2110D loop (Dependent Eligibility or Benefit Inquiry).</summary>
    Public NotInheritable Class Loop2110DFactory

        Private Sub New()

        End Sub

        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ">EQ</see> interface (Dependent Eligibility or Benefit Inquiry).</summary>
        Public Shared Function CreateEQ() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.EQ
            Return New Global.Madjic.Edi.Dom.Segments.EQ_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III">III</see> interface (Dependent Eligibility or Benefit Additional Inquiry Information).</summary>
        Public Shared Function CreateIII() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.III
            Return New Global.Madjic.Edi.Dom.Segments.III_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.REF">REF</see> interface (Dependent Additional Information).</summary>
        Public Shared Function CreateREF() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.REF
            Return New Global.Madjic.Edi.Dom.Segments.REF_Obj
        End Function
        '''<summary>Creates an object that implements the <see cref ="Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.DTP">DTP</see> interface (Dependent Eligibility/Benefit Date).</summary>
        Public Shared Function CreateDTP() As Global.Madjic.Edi.Dom.Transactions.Transaction270.Transaction270_B1.Segments.Loop2110D.DTP
            Return New Global.Madjic.Edi.Dom.Segments.DTP_Obj
        End Function
    End Class
End Namespace
