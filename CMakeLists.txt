cmake_minimum_required(VERSION 3.25)
project(Heroes)

set(CMAKE_CXX_STANDARD 17)

add_executable(Heroes main.cpp lib/Hero.h lib/Mage.h lib/Barbarian.h)
