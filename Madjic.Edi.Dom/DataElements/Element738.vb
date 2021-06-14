Namespace DataElements
    '''<summary>Measurement Qualifier</summary>
    '''<remarks>
    '''<para>Code identifying a specific product or process characteristic to which a measurement applies</para>
    '''</remarks>
    Partial Friend Class Element738
        Inherits IdentifierElement

        Public Sub New()
            MyBase.New(1, 3, Nothing,
                       "1,10,11,12,13,14,15,16,18,19,1F,2,20,21,22,23,24,25,26,27,28,29,2F,3,30,31,32,33,34,35,36,37,38,3A,3B,3C,3D,3E,3F,3G,3H,3I,3J,4,40,41,42,43,44,45,48,49,4F,5,50,51,52,53,54,56,57,58,5F,6,62,63,65,66,68,6F,7,78,79,8,8F,9,A,A1,A2,A3,A4,A5,A6,A7,A9,AA,AAP,AB,ABO,ABR,ABS,AC,ACN,AD,ADH,ADM,AE,AF,AG,AGE,AGI,AH,AI,AJ,AK,AL,ALK,ALN,ALP,AM,AMI,AMW,AN,AOX,AP,API,APP,AS,ASH,ASY,AT,AU,AV,AVT,AW,AX,AY,AZ,B,B1,B2,B3,B4,B5,B6,BA,BB,BC,BD,BDP,BE,BF,BG,BH,BHF,BHS,BIC,BJ,BK,BL,BN,BND,BO,BOR,BP,BQ,BR,BRS,BSW,BT,BU,BUD,BW,BX,C,C0,C1,C2,C3,C4,CA,CAU,CC,CCF,CCG,CD,CE,CF,CG,CGR,CH,CHA,CHB,CHC,CHG,CHL,CI,CIV,CJ,CK,CL,CLA,CLB,CLN,CM,CN,CO,COF,COH,COL,CON,COR,COS,COT,CP,CPF,CPS,CPT,CQ,CR,CRF,CRL,CRN,CRT,CS,CSC,CSR,CST,CT,CTG,CTT,CU,CUT,CW,CWT,CX,CY,CYB,D,D1,D2,D3,D4,D5,D6,D7,D8,D9,DA,DAT,DB,DC,DCT,DD,DE,DEM,DF,DG,DH,DI,DIL,DIR,DIS,DJ,DK,DL,DLC,DM,DME,DMF,DN,DO,DOC,DP,DPM,DR,DRY,DS,DT,DU,DW,DWP,DY,E,E0,E1,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EL,ELC,ELE,ELI,ELL,ELO,ELP,ELS,ELT,ELV,ELW,ELX,EM,EN,EP,EPL,ES,ET,EVL,EVR,EW,EX,EXH,EXT,F,F1,F2,F3,F4,F5,F6,F7,F8,F9,FA,FB,FBP,FC,FD,FE,FF,FG,FH,FI,FIL,FIN,FIT,FJ,FK,FL,FLD,FLN,FLP,FLT,FLV,FML,FMZ,FN,FNL,FNS,FOA,FOH,FOI,FOR,FP,FPV,FQ,FR,FS,FSI,FT,FU,FUD,FV,FW,FX,FY,FZ,G,G1,G2,G3,G4,GA,GB,GC,GD,GE,GEL,GF,GG,GGR,GH,GI,GIR,GJ,GK,GL,GLE,GM,GN,GO,GOR,GP,GQ,GR,GRA,GRI,GS,GT,GW,H,H1,H2O,H8,H9,HA,HAR,HAZ,HB,HC,HCG,HCH,HCI,HCJ,HCK,HCL,HCM,HCN,HCO,HCP,HCQ,HCR,HCS,HCT,HCU,HCV,HCW,HCX,HD,HE,HF,HG,HH,HHW,HI,HIB,HJ,HK,HL,HM,HO,HOC,HP,HR,HT,HTE,HVM,HWS,HYD,HZ,HZC,I,IA,IB,IC,ID,IDE,IE,IF,IG,IGA,IGR,IH,IHV,II,IJ,IK,IL,IM,IMA,IMP,IN,IND,INS,IO,IP,IPI,IQ,IR,IRA,IS,IT,ITD,IU,IV,IW,IX,IXD,IY,IZ,JA,JOM,KA,KB,KN,KVL,L,L0,L1,LA,LAI,LB,LC,LC5,LCG,LD,LD5,LDH,LE,LEF,LF,LG,LIR,LIV,LL,LLD,LM,LN,LO,LOI,LOS,LOW,LP,LPG,LPL,LPR,LS,LSA,LSK,LSS,LT,LTD,LW,M,M1,M2,M3,M4,M5,M6,MA,MAT,MB,MC,MCN,MD,MDL,ME,MEA,MEF,MEL,MEP,MER,MF,MG,MH,MHI,MI,MIC,MIL,MJ,MK,MM,MN,MO,MOI,MOR,MP,MPR,MPT,MQ,MR,MS,MT,MTD,MU,MUL,MV,MW,MX,MY,N,NA,NB,NC,ND,NEU,NF,NG,NH,NI,NIL,NJ,NK,NL,NM,NNW,NO,NOC,NON,NOR,NOX,NP,NS,NU,NV,O,O1,OA,OAP,OB,OBT,OC,OCG,OCR,OD,ODR,OE,OF,OG,OH,OI,OIL,OJ,OK,OL,OLE,OM,ON,OO,OP,OQ,OR,ORC,OS,OT,OTE,OTH,OTT,OV,OW,OX,OXI,OXS,OY,P1,PA,PAR,PB,PBD,PC,PD,PDE,PDG,PE,PER,PF,PFO,PG,PH,PHA,PHW,PI,PIC,PJ,PK,PL,PM,PN,PO,POC,POD,POP,PP,PPS,PQ,PQL,PR,PRA,PRE,PRF,PRI,PRL,PRN,PRO,PRQ,PRY,PRZ,PS,PSA,PSP,PSW,PT,PU,PV,PW,PWA,PWE,PWF,PX,PY,PZ,Q,QA,QB,QC,QD,QE,QF,QG,QI,QJ,QK,QL,QUR,R,R1,R10,R18,R2,R3,R4,R7,R8,RA,RAD,RAF,RB,RC,RD,RE,REA,RED,REF,REI,REL,RES,RF,RG,RH,RI,RJ,RK,RL,RM,RN,RO,ROH,ROX,RP,RQ,RR,RS,RSZ,RT,RTB,RU,RUD,RV,RVP,RW,RX,RY,S,S1,S10,S12,S18,S2,S3,S4,S5,S6,S7,S8,S9,SA,SAL,SAP,SB,SC,SCH,SD,SE,SEV,SF,SFC,SG,SH,SHA,SI,SIL,SJ,SK,SL,SLD,SLI,SM,SMB,SMD,SN,SO,SOD,SOF,SP,SPG,SPH,SPR,SPS,SQ,SR,SS,ST,STA,STL,STP,SU,SUM,SUR,SUT,SV,SVL,SW,SX,SXX,SY,SZ,T,T1,T2,T3,T4,T5,T50,T90,TA,TAS,TB,TC,TCL,TD,TDP,TE,TEE,TES,TEX,TF,TG,TH,TI,TJ,TK,TL,TM,TN,TO,TOA,TOR,TOX,TP,TPF,TPL,TPQ,TPS,TQ,TR,TRA,TRC,TRD,TRN,TRS,TRT,TS,TSZ,TT,TTL,TU,TUR,TV,TVD,TW,TWD,TX,TY,U,UA,UCB,UG,UNA,UNI,UNK,V,VAD,VAP,VBA,VCG,VH,VIN,VIS,VO,VOC,VOL,VOT,VOV,VOW,VSO,VW,VWT,W,WA,WB,WC,WD,WDE,WE,WEL,WF,WH,WI,WL,WM,WOD,WPF,WPL,WPS,WR,WRA,WSK,WT,WTB,WU,WX,X,XA,XH,XP,XQ,XZ,YA,YB,YC,YD,YPE,ZAL,ZAS,ZB,ZBI,ZBT,ZBZ,ZC,ZCA,ZCB,ZCD,ZCE,ZCM,ZCO,ZCR,ZCU,ZD,ZET,ZF,ZFE,ZFL,ZFS,ZG,ZGE,ZH,ZHP,ZHS,ZHX,ZIB,ZIP,ZMG,ZMN,ZMO,ZMT,ZN,ZNB,ZNI,ZNP,ZO,ZOC,ZP,ZPB,ZPP,ZPT,ZR,ZS,ZSB,ZSE,ZSI,ZSN,ZTA,ZTB,ZTE,ZTI,ZV,ZW,ZZN,ZZR,ZZZ")
            Initialize
        End Sub

        Partial Private Sub Initialize()
        End Sub

        Friend Shared Function FromReader(fullElement As String, reader As EdiReader.SegmentReader) As Element738
            Dim rval As New Element738

            rval.Value = fullElement
            Return rval
        End Function
    End Class
End NameSpace