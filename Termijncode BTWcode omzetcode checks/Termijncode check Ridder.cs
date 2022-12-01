If(    ([Termijncode].[Code]=="001")     
    OR ([Termijncode].[Code]=="002")
    OR ([Termijncode].[Code]=="003") 
    OR ([Termijncode].[Code]=="004")
    OR ([Termijncode].[Code]=="007" AND [Relatie].[code]<>"517")  
    OR ([Termijncode].[Code]=="008"), 
                                        "Termijncode fout", 

If(    ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("30000")    AND [Relatie].[code]=="150")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="9060")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="1125")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="1025")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="1062")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="495")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="9050")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="9072")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="2004")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="9069")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="3004")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("50000")    AND [Relatie].[Code]=="18003")
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="18003"  AND (LEFT([Bestemmingsadres].[Naam],3)=="AWL"))
    OR ([Termijncode].[Code]=="005" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="18003"  AND (RIGHT([Bestemmingsadres].[Naam],3)=="AWL"))

    OR ([Termijncode].[Code]=="006" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[Code]=="9053")
    OR ([Termijncode].[Code]=="006" AND [@Total net amount]>=ConvertStringToInt("10000")    AND [Relatie].[code]<>"26022"
                                                                                            AND [Relatie].[code]<>"9060" 
                                                                                            AND [Relatie].[code]<>"9091"
                                                                                            AND [Relatie].[code]<>"1125"
                                                                                            AND [Relatie].[code]<>"1025"
                                                                                            AND [Relatie].[code]<>"1062"
                                                                                            AND [Relatie].[code]<>"495"
                                                                                            AND [Relatie].[code]<>"9050"
                                                                                            AND [Relatie].[code]<>"9072"
                                                                                            AND [Relatie].[code]<>"2004"
                                                                                            AND [Relatie].[code]<>"9069"
                                                                                            AND [Relatie].[Code]<>"1053"
                                                                                            AND [Relatie].[Code]<>"1122"
                                                                                            AND [Relatie].[Code]<>"1041"
                                                                                            AND [Relatie].[Code]<>"19017"
                                                                                            AND [Relatie].[Code]<>"517"
                                                                                            AND [Relatie].[Code]<>"9057"
                                                                                            AND [Relatie].[Code]<>"3004"
                                                                                            AND [Relatie].[Code]<>"18003")

    OR ([Termijncode].[Code]=="007" AND [Relatie].[Code]=="517" )                                                                                        
                                                                                            
    OR ([Termijncode].[Code]=="009"                                                         AND [Relatie].[code]=="9043")
    OR ([Termijncode].[Code]=="009"                                                         AND [Relatie].[code]=="9042")
    OR ([Termijncode].[Code]=="009"                                                         AND [Relatie].[Code]=="483")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="1125")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("30000")    AND [Relatie].[code]=="150")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="1082")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="1025")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="1062")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="495")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="9050")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="9072")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="2004")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="9060")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]=="9069")
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("50000")    AND [Relatie].[Code]=="18003"  AND (LEFT([Bestemmingsadres].[Naam],3)<>"AWL")) 
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("50000")    AND [Relatie].[Code]=="18003"  AND (Right([Bestemmingsadres].[Naam],3)<>"AWL")) 
    
    OR ([Termijncode].[Code]=="009" AND [@Total net amount]<=ConvertStringToInt("10000")    AND [Relatie].[code]<>"26022"
                                                                                            AND [Relatie].[code]<>"9060"
                                                                                            AND [Relatie].[code]<>"9091"
                                                                                            AND [Relatie].[code]<>"1082" 
                                                                                            AND [Relatie].[code]<>"1125"
                                                                                            AND [Relatie].[code]<>"1025"
                                                                                            AND [Relatie].[code]<>"1062"
                                                                                            AND [Relatie].[code]<>"495"
                                                                                            AND [Relatie].[code]<>"9050"
                                                                                            AND [Relatie].[code]<>"9072"
                                                                                            AND [Relatie].[code]<>"2004"
                                                                                            AND [Relatie].[code]<>"483"
                                                                                            AND [Relatie].[Code]<>"1053"
                                                                                            AND [Relatie].[Code]<>"1122"
                                                                                            AND [Relatie].[Code]<>"1041"
                                                                                            AND [Relatie].[Code]<>"19017"
                                                                                            AND [Relatie].[Code]<>"517"
                                                                                            AND [Relatie].[Code]<>"9057"
                                                                                            AND [Relatie].[Code]<>"18003")       
                                                                                                
    OR ([Termijncode].[Code]=="BITO-DE_1"   AND [Relatie].[Code]=="26022"   AND [@Total net amount]<=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="BITO-DE_2"   AND [Relatie].[Code]=="26022"   AND [@Total net amount]>=ConvertStringToInt("10000") AND [@Total net amount]<=ConvertStringToInt("30000"))
    OR ([Termijncode].[Code]=="BITO-DE_3"   AND [Relatie].[Code]=="26022"   AND [@Total net amount]>=ConvertStringToInt("30000"))
    
    OR ([Termijncode].[Code]=="STOW-DE"     AND [Relatie].[Code]=="1053"    AND [@Total net amount]>=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="STOW-DE"     AND [Relatie].[Code]=="1122"    AND [@Total net amount]>=ConvertStringToInt("10000"))
    
    OR ([Termijncode].[Code]=="STOW-INT"    AND [Relatie].[Code]=="1041"    AND [@Total net amount]<=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="STOW-INT"    AND [Relatie].[Code]=="9057"    AND [@Total net amount]<=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="STOW-INT"    AND [Relatie].[Code]=="1122"    AND [@Total net amount]<=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="STOW-INT"    AND [Relatie].[Code]=="9091"    AND [@Total net amount]<=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="STOW-INT"    AND [Relatie].[Code]=="1053"    AND [@Total net amount]<=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="STOW-INT"    AND [Relatie].[Code]=="19017"   AND [@Total net amount]<=ConvertStringToInt("10000"))

    OR ([Termijncode].[Code]=="STOW-INT_1"  AND [Relatie].[Code]=="1041"    AND [@Total net amount]>=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="STOW-INT_1"  AND [Relatie].[Code]=="9091"    AND [@Total net amount]>=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="STOW-INT_1"  AND [Relatie].[Code]=="9057"    AND [@Total net amount]>=ConvertStringToInt("10000"))
    OR ([Termijncode].[Code]=="STOW-INT_1"  AND [Relatie].[Code]=="19017"   AND [@Total net amount]>=ConvertStringToInt("10000"))
                                                                                                                                    ,"Termijncode correct","Termijncode fout"))
