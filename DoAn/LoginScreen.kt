package com.example.simplenagivitionthem

import android.accounts.Account
import androidx.compose.foundation.background
import androidx.compose.foundation.layout.Arrangement
import androidx.compose.foundation.layout.Column
import androidx.compose.foundation.layout.Row
import androidx.compose.foundation.layout.fillMaxSize
import androidx.compose.foundation.layout.fillMaxWidth
import androidx.compose.foundation.layout.padding
import androidx.compose.foundation.text.KeyboardOptions
import androidx.compose.material3.Button
import androidx.compose.material3.ExperimentalMaterial3Api
import androidx.compose.material3.Text
import androidx.compose.material3.TextField
import androidx.compose.runtime.Composable
import androidx.compose.runtime.mutableStateOf
import androidx.compose.runtime.remember
import androidx.compose.ui.Alignment
import androidx.compose.ui.Modifier
import androidx.compose.ui.graphics.Color
import androidx.compose.ui.text.font.FontWeight
import androidx.compose.ui.text.input.KeyboardType
import androidx.compose.ui.unit.dp
import androidx.compose.ui.unit.sp
import androidx.navigation.NavController

@OptIn(ExperimentalMaterial3Api::class)
@Composable
fun LoginScreen(navController: NavController)
{

    var username = remember { mutableStateOf("") }
    var password = remember { mutableStateOf("") }

    var errorMessage = remember { mutableStateOf("") }
    fun validateInput() {
        if (username.value.isEmpty() || password.value.isEmpty()) {
            errorMessage.value = "Vui lòng nhập đầy đủ username và password"
        } else {
            errorMessage.value = ""
        }
    }
    Column(modifier = Modifier
        .fillMaxSize()
        .background(Color.White),
        verticalArrangement = Arrangement.Center,
        horizontalAlignment = Alignment.CenterHorizontally) {
        Text(text = "LOGIN", fontSize = 40.sp, fontWeight = FontWeight.ExtraBold)
        TextField(
            modifier = Modifier.padding(top = 15.dp),value = "", onValueChange ={},
            label={ Text(text = "Account") },
            keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Text)
        )
        TextField(
            modifier = Modifier.padding(top = 15.dp),value = "", onValueChange ={},
            label={ Text(text = "Password") },
            keyboardOptions = KeyboardOptions(keyboardType = KeyboardType.Password)
        )
        Row (
            modifier = Modifier.fillMaxWidth(),
            horizontalArrangement = Arrangement.SpaceEvenly,
            verticalAlignment = Alignment.CenterVertically
        ){
            Button(modifier = Modifier.padding(top = 15.dp), onClick = {
                validateInput()
               }) {
                Text(text = "LOGIN")
            }
            Button(modifier = Modifier.padding(top = 15.dp), onClick = {
                navController.navigate(Screen.Register.route)
            }) {
                Text(text = "REGISTER")
            }
        }
    }
}
