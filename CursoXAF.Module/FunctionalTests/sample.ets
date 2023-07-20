;#DropDB CursoXAFEasyTest

#Application CursoXAFWin
;#Application CursoXAFWeb

*FillForm
 User Name = Admin
*Action Log In

#IfDef CursoXAFWin

*Action About...
 
*Action OK

#EndIf

#IfDef CursoXAFWeb
*Action Navigation(My Details)
#EndIf
