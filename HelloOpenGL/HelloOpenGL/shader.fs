#version 330 core
out vec4 FragColor;

in vec3 ourColor;

void main()
{
    FragColor = vec4(vec3(0.2,0.5,0.2), 1.0f);
}