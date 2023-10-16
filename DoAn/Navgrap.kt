package com.example.simplenagivitionthem

import androidx.compose.runtime.Composable
import androidx.navigation.NavHostController
import androidx.navigation.compose.NavHost
import androidx.navigation.compose.composable

@Composable
fun Navgrap(navController: NavHostController)
{
    NavHost(navController = navController,
        startDestination = Screen.Login.route
    )
    {
        composable(
            route = Screen.Login.route
        )
        {
            LoginScreen(navController)
        }
        composable(
            route = Screen.Register.route
        )
        {
            RegisterScren(navController)
        }
    }}
